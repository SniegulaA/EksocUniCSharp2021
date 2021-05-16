using Sniegula.TripManagement.Data.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.TripManagement.Data.model
{
    public class Person
    {
       // public Person() { 
        
      //  }

        public Person(BookingPhase phase) {

            if (phase == BookingPhase.FIRST) {
                ToPay = Person.TRIP_COST_FOR_A_PERSON - Person.TRIP_COST_FOR_A_PERSON * 30 / 100;
            }else if(phase == BookingPhase.SECOND)
            {
                ToPay = Person.TRIP_COST_FOR_A_PERSON - Person.TRIP_COST_FOR_A_PERSON * 15 / 100;
            }
            else {
                ToPay = Person.TRIP_COST_FOR_A_PERSON;
            }
        }

  


        public static decimal TRIP_COST_FOR_A_PERSON = 500;
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal PayedSum { get; set; }

        public decimal ToPay { get; set; }

        public DateTime BirthdayDate { get; set; }

        public BookingPhase BookingPhase { get; set; }

        public virtual void  PayForATrip(decimal amount) {

            if (amount > ToPay)
            {

                AmountToBigException exception = new AmountToBigException("Za duża kwota", ToPay);
                throw exception;

            }
            else {

                PayedSum = PayedSum + amount;
                ToPay = ToPay - amount;

            }
        }


        public override string ToString()
        {
            return Name + " " + Surname + " " + PayedSum;
        }
    }
}
