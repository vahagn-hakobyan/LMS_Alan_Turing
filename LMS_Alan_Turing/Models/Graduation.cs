using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Graduation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int PathsId { get; set; }
        public int GraduationsIdentity { get; set; }

        public virtual Path Paths { get; set; }
    }
}
