using Sniegula.TripManagement.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.TripManagement.Logic
{
    public class TripService
    {
        List<Person> people = new List<Person>();


        public TripService() {

            Person p1 = new Person(BookingPhase.FIRST);
            p1.Name = "Jan";
            p1.Surname = "Kowalski";

            Person p2 = new Person(BookingPhase.SECOND);
            p2.Name = "Joanna";
            p2.Surname = "Krajewska";

            people.Add(p1);
            people.Add(p2);


        }

        public List<Person> GetAllPeople() {
            return people;
        
        }

        public void PayForATrip(Person p, decimal amount) {
            /*foreach (Person person in people) {

                if (person.Equals(p)) {

                    person.PayForATrip(amount);
                }
            }*/

            people.Find(person => person.Equals(p)).PayForATrip(amount);

        }
    }
}
