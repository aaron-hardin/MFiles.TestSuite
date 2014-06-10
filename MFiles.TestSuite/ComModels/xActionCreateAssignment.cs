using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace MFiles.TestSuite.ComModels
{
    public class xActionCreateAssignment
    {
        public xUserOrUserGroupIDEx[] AssignedTo { get; set; }
        public bool Deadline { get; set; }
        public int DeadlineInDays { get; set; }
        public string Description { get; set; }
        public xUserOrUserGroupIDEx[] MonitoredBy { get; set; }
        public string Title { get; set; }

        public xActionCreateAssignment() { }

        public xActionCreateAssignment(ActionCreateAssignment aca)
        {
            this.AssignedTo = (from UserOrUserGroupIDEx ugEx in aca.AssignedTo select new xUserOrUserGroupIDEx(ugEx)).ToArray();
            this.Deadline = aca.Deadline;
            this.DeadlineInDays = aca.DeadlineInDays;
            this.Description = aca.Description;
            this.MonitoredBy = (from UserOrUserGroupIDEx ugEx in aca.MonitoredBy select new xUserOrUserGroupIDEx(ugEx)).ToArray();
            this.Title = aca.Title;
        }
    }
}
