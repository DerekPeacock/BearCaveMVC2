using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearCaveMVC2.Models
{
    public class Unit
    {
        public int UnitID { get; set; }
        public int DoorNum { get; set; } 
        public int Floor { get; set; } //null for houses with one occupant 
        public float DefaultRent { get; set; } //rent cost is weekly; if rent period is monthly, then weeklyrent * 52.14 / 12 = monthlyrent
        public float CurrentRent { get; set; }

        
    }
}
