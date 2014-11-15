using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine("Please enter your name:  ");
            person1.Name = Console.ReadLine();
            Console.WriteLine("Please enter your age:  ");
            person1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + person1.Name);

            Console.WriteLine();
            person1.Speak("Oh what a beautiful morning!");

            Console.WriteLine();
            person1.AddTwoIntegers(2, 5);

            /* Console.WriteLine("What is your name?  ");
                string name = Console.ReadLine();

            
         
                 Console.WriteLine("What is your age?  ");
                 int age = int.Parse(Console.ReadLine());
                 */



            //     //Console.WriteLine();
            //     p1.Speak("Oh what a beautiful morning!");

            //     public void AddTwoIntegers(int integer1, int integer2)
            //     {

            //       int Sum = integer1 + integer2;
            //     }
            //     }
            //}
        }
    }
}

