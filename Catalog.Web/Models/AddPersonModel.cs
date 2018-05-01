using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Catalog.Web.Models
{
    public class AddPersonModel
    {
        public int TeamId { get; set; }
        public int PersonId { get; set; }
        public List<SelectListItem> People { get; set; }
    }
}