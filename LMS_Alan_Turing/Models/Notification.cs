using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int? SubmissionsId { get; set; }
        public int? AssignmentsId { get; set; }
        public int? EventsId { get; set; }

        public virtual Assignment Assignments { get; set; }
        public virtual Event Events { get; set; }
        public virtual Submission Submissions { get; set; }
    }
}
