using System;
using System.Collections.Generic;


namespace Sniegula.CarWorkshop.Data
{
    public class Mechanic
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int HourlyRage { get; set; }

        private List<CarBrand> carBrands = new List<CarBrand>();

        public List<CarBrand> CarBrands { get { return carBrands; } }


        public void AddCarBand(CarBrand carBrand) {

           this.carBrands.Add(carBrand);
        }


        public bool CanRepairCarBrand(CarBrand carBrand) {
            //prawda jeżeli marka znajduje się na liście
            //1 przykład
            foreach (CarBrand carBrandOnList in carBrands) {

                if (carBrandOnList.Equals(carBrand))
                {
                    return true;
                }
            }
            return false;

            //2 przykład
            //bool second =  carBrands.Exists(carBrandOnList => carBrandOnList.Equals(carBrand));
            //return second;

            //bool thirdExample=  carBrands.Contains(carBrand);
            //return thirdExample;


        }


        public override string ToString() {

            return this.Name + " " + this.Surname + " " + this.HourlyRage;
        }
    }
}
