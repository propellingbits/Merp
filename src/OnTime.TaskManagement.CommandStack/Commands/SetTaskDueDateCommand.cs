﻿using MementoFX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTime.TaskManagement.CommandStack.Commands
{
    public class SetTaskDueDateCommand : Command
    {
        public Guid TaskId { get; set; }

        public DateTime DueDate { get; set; }
    }
}
