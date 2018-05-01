using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.Web.Models
{
    public class TeamDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Persons { get; set; }
    }
}