using Catalog.Core;
using Catalog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.Web.Controllers
{
    public class TeamsController : Controller
    {
        public ActionResult Index(int id)
        {

            var dataservice = DataService.GetInstance();
            var team = dataservice.Teams.FirstOrDefault(t => t.Id == id);

            var model = new TeamDetailsModel
            {
                Id = team.Id,
                Name = team.Name,
                Persons = dataservice.People.Where(p => p.Team?.Id == id).ToList()
            };

            return View(model);
        }

        public ActionResult AddPersonForm(int id)
        {
            var model = new AddPersonModel();
            var dataservice = DataService.GetInstance();
            var people = dataservice.People.Where(p => p.Team == null || p.Team.Id != id);
            model.People = people.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();
            model.TeamId = id;

            return View(model);
        }

        [HttpPost]
        public ActionResult AddPerson(AddPersonModel model)
        {
            var dataService = DataService.GetInstance();
            var team = dataService.Teams.First(t => t.Id == model.TeamId);
            dataService.People.First(p => p.Id == model.PersonId).Team = team;

            return RedirectToAction("Index", new {id = model.TeamId });
        }

    }
}