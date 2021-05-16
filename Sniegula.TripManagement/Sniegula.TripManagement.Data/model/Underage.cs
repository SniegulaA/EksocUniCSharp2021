using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.TripManagement.Data.model
{
    public class Underage : Person
    {
        public Underage(BookingPhase phase) : base(phase)
        {
     
        }

        public Person Supervisor { get; set; }


        public virtual void PayForATrip(decimal amount)
        {
        }
    }
}
