using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.CarWorkshop.Data
{
    class Program
    {
        static void Main(string[] args)
        {

           List<CarBrand> carsBrands =  Enum.GetValues(typeof(CarBrand)).Cast<CarBrand>().ToList();
           CarBrand[] carBrands3 = (CarBrand[])Enum.GetValues(typeof(CarBrand));

            foreach (CarBrand carBrand in carBrands3) {
                Console.WriteLine(carBrand.ToString());

                if (carBrand.Equals(CarBrand.BMW)) {
                    Console.WriteLine("marka równa się BMW");
                }

            }

            Console.ReadLine();
        }
    }
}
