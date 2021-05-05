using Sniegula.CarWorkshop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class CarService
    {
        List<Mechanic> mechanics = new List<Mechanic>();
        List<Repair> repairs = new List<Repair>();


        public CarService() {

            //Utwórz 4 przykładowych mechaników
            Mechanic mechanic = new Mechanic();
            mechanic.Name = "Jan";
            mechanic.Surname= "Kowal";
            mechanic.HourlyRage = 15;
            mechanic.AddCarBand(CarBrand.BMW);
            mechanic.AddCarBand(CarBrand.MERCEDES);


            Mechanic mechanic2 = new Mechanic();
            mechanic2.Name = "Piotr";
            mechanic2.Surname = "Marcinkiewicz";
            mechanic2.HourlyRage = 20;
            mechanic2.AddCarBand(CarBrand.KIA);
            mechanic2.AddCarBand(CarBrand.BMW);

            Mechanic mechanic3 = new Mechanic();
            mechanic3.Name = "Joanna";
            mechanic3.Surname = "Podolska";
            mechanic3.HourlyRage = 30;
            mechanic3.AddCarBand(CarBrand.TOYOTA);
            mechanic3.AddCarBand(CarBrand.MERCEDES);


            mechanics.Add(mechanic);

            mechanics.Add(mechanic2);

            mechanics.Add(mechanic3);


            //Utwórz przykładowe naprawy
            Repair r1 = new Repair();
            r1.CarBrand = CarBrand.TOYOTA;
            r1.MechanicResponsible = mechanic3;
            r1.RegistrationNumber = "EL4567k";
            r1.TimeInHours = 5;
            r1.RepairDate = DateTime.Today;
            repairs.Add(r1);

            Repair r2 = new Repair();
            r2.CarBrand = CarBrand.KIA;
            r2.MechanicResponsible = mechanic2;
            r2.TimeInHours = 20;
            r2.RegistrationNumber = "NN000000";
            r2.RepairDate = new DateTime(2021, 04, 30);
            repairs.Add(r2);

        }

        public void AddNewRepair(Repair repair) {
            repairs.Add(repair);
        }

        public List<CarBrand> GetAllCarBrands() {
            List<CarBrand> carsBrands = Enum.GetValues(typeof(CarBrand)).Cast<CarBrand>().ToList();
            return carsBrands;

        }


        public List<Mechanic> GetMechanicsForBrand(CarBrand carBrand) {
            List<Mechanic> filteredList = new List<Mechanic>();
            
            //1 sposób
            foreach (Mechanic mechanicOnlist in mechanics) {


                if (mechanicOnlist.CanRepairCarBrand(carBrand)) {
                    filteredList.Add(mechanicOnlist);
                }
            
            }
       
            //2 sposób
           filteredList =  mechanics.FindAll(t => t.CanRepairCarBrand(carBrand));
           
            
            
            
            return filteredList;
        }

        public List<Repair> GetAllRepairs() {
            return repairs;
        }

    }
}
