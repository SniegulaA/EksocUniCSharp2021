using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.TripManagement.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                //Kod potencjalnie niebezpieczny
                string someVariable = "3";
                int someNumber = int.Parse(someVariable);

                MyCustomException myException = new MyCustomException("Nieprawidłowe działanie programu");
                myException.MyCustomAttribute = "Some attribute";

                throw myException;


            }
            catch (FormatException ex)
            {

                //Jeżeli wyjątek wystąpi
                Console.WriteLine("Wyjątek format exception wystąpił");
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                // Console.WriteLine("Stack trace" + ex.StackTrace);


            }
            catch (MyCustomException ex) {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("CustomValue: " + ex.MyCustomAttribute);
            }
            finally {

                //Wejdziemy zawsze, nie ważne czy wyjątek wystąpi
                Console.WriteLine("Koniec, znajduję się w finally");

            }
            */


            string textVariable = "6";
            int numberVariable;
            bool conversionResult;
            conversionResult = int.TryParse(textVariable, out numberVariable);



            int a = 4;
            int b = 7;
            int sum;
            bool isSumGreaterThanZero;

            Program program = new Program();
            sum = program.CustomAdd(a, b, out isSumGreaterThanZero);

            Console.ReadLine();
        }


        public int CustomAdd(int a, int b, out  bool isGreaterThanZero) {

            int sum = a + b;
            isGreaterThanZero = sum > 0;

            return sum;
        
        }
    }
}
