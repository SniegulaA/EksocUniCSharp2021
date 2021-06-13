using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.genericsFirstExample
{
    public class FirstClassWithGenerics <T,S>
    {
       public T FIrstParam { get; set; }
       public S SecondParam { get; set; }


        public T SomeFunction()
        {
            return FIrstParam;
        }

        public void SecondFunction(S attr) {

            Console.WriteLine(attr.ToString());
        }




    }
}
