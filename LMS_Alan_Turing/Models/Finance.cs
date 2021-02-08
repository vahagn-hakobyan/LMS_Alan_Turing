using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Finance
    {
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public decimal Amount { get; set; }
        public string Purpose { get; set; }
        public int ReceiverId { get; set; }
        public int SenderId { get; set; }

        public virtual User Receiver { get; set; }
        public virtual User Sender { get; set; }
    }
}
