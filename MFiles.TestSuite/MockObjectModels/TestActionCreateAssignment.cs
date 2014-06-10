using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFiles.TestSuite.ComModels;
using MFilesAPI;

namespace MFiles.TestSuite.MockObjectModels
{
    public class TestActionCreateAssignment : ActionCreateAssignment
    {
        public TestActionCreateAssignment() { }

        public TestActionCreateAssignment(xActionCreateAssignment aca)
        {
            this.AssignedTo = new UserOrUserGroupIDExs();
            foreach (xUserOrUserGroupIDEx userGroupIdEx in aca.AssignedTo)
            {
                this.AssignedTo.Add(-1, new TestUserOrUserGroupIDEx(userGroupIdEx));
            }
            this.Deadline = aca.Deadline;
            this.DeadlineInDays = aca.DeadlineInDays;
            this.Description = aca.Description;
            this.MonitoredBy = new UserOrUserGroupIDExs();
            foreach (xUserOrUserGroupIDEx userGroupIdEx in aca.MonitoredBy)
            {
                this.MonitoredBy.Add(-1, new TestUserOrUserGroupIDEx(userGroupIdEx));
            }
            this.Title = aca.Title;
        }

        public UserOrUserGroupIDExs AssignedTo { get; set; }
        public UserOrUserGroupIDs AssignedToUsers { get; set; }
        
        public ActionCreateAssignment Clone()
        {
            TestActionCreateAssignment aca = new TestActionCreateAssignment
            {
                Title = this.Title,
                Deadline = this.Deadline,
                DeadlineInDays = this.DeadlineInDays,
                Description = this.Description,
                MonitoredBy = new UserOrUserGroupIDExs(),
                AssignedTo = new UserOrUserGroupIDExs()
            };
            for (int i = 1; i <= this.AssignedTo.Count; ++i)
            {
                UserOrUserGroupIDEx userGroupIdEx = this.AssignedTo[i];
                aca.AssignedTo.Add(-1, userGroupIdEx.Clone());
            }
            for (int i = 1; i <= this.MonitoredBy.Count; ++i)
            {
                UserOrUserGroupIDEx userGroupIdEx = this.MonitoredBy[i];
                aca.MonitoredBy.Add(-1, userGroupIdEx.Clone());
            }

            return aca;
        }

        public bool Deadline { get; set; }

        public int DeadlineInDays { get; set; }

        public string Description { get; set; }

        public UserOrUserGroupIDExs MonitoredBy { get; set; }

        public UserOrUserGroupIDs MonitoredByUsers { get; set; }

        public string Title { get; set; }
    }
}
