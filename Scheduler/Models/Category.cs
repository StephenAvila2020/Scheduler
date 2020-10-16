using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Name { get; set; }
        public DateTime StartOne { get; set; }
        public DateTime EndOne { get; set; }
        public DateTime StartTwo { get; set; }
        public DateTime EndTwo { get; set; }
    }
}

