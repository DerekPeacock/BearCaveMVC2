using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearCaveMVC2.Models
{
    public class Maintenance
    {
        public int JobID { get; set; }
        public string TypeOfWork { get; set; }
        public DateTime DateOfWork { get; set; }
        public DateTime DateFinished { get; set; }
        public string Description { get; set; }

    }
}
