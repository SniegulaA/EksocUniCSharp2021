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


    }
}
