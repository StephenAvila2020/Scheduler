using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int CategoryId { get; set; }
        public DateTime Date { get; set; }
        public bool UpForTrade { get; set; }
        public Employee Employee { get; set; }
        public Category Category { get; set; }
    }
}
