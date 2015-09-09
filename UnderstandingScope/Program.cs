using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {

        private static string k = ""; //This is a field, it has to be static because you want it to be accessible from all over your class

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine("l: " l); here l wont be accessible as well, only inside the if
            }
            //The variable i is not accessible from here, outside the for
            //Console.WriteLine(i);

            Console.WriteLine("Outside of the for: " + j);
            //Console.WriteLine("k: " + k); K will be accessible because it was declared inside the main

            helperMethod();//calling the method with the value of K


            Car car = new Car();

            car.DoSomething();

            Console.ReadLine();
        }

        static void helperMethod()
        {
            Console.WriteLine("k from the helperMethod: " + k);
        }


        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine("Calling public method: "+helperMethod());
            }

            private string helperMethod()
            {
                return "Hello World from private method";
            }
        }

    }
}
