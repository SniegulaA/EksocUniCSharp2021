using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniegula.GenericsExample.Logic.genericsFirstExample
{
   public  class Example1
    {

        public void ExampleList()
        {
            ArrayList oldList = new ArrayList();
            oldList.Add("some text");
            oldList.Add(1);

            object firstElement =  oldList[0];

          
           string firstElementString = (string)oldList[0];
           string secondElement = (string)oldList[1];



            List<int> myList = new List<int>();
            myList.Add(3);
            //myList.Add("some text"); //niedozwolone
        }


        public void UseMyGenericClass()
        {
            FirstClassWithGenerics<int, int> firstClssFithGenericObject 
                = new FirstClassWithGenerics<int, int>();

            FirstClassWithGenerics<int, string> firstClssFithGenericObject2
              = new FirstClassWithGenerics<int, string>();


            SecondClassWithGenerics secondClassObject = new SecondClassWithGenerics();
            secondClassObject.MethodWithGenerics<int>(5);


            

        }



    }
}
