﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merp.Web.Site.Areas.OnTime.Model.Task
{
    public class IncompleteViewModel
    {
        public Guid TaskId { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
