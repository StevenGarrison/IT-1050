using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Person
    {
       private string _name;
       private int _age;
       
        //I learned what I have here from Lynda.com.  Are these constructors?
       public int Age
       {
           get { return this._age; }
           set { this._age = value; }
       }
       public string Name
       {
           get { return this._name; }
           set { this._name = value; }
       }
       //is this necessary?
       public Person()
       {
          
       }
       
       //what I originally had as constructors
       public Person (string firstParameter, int secondParameter)
        {
           _name = firstParameter;
           _age = secondParameter;
        }

       //void method "Speak"
       public void Speak(string phrase)//one string parameter
       {
           Console.WriteLine(_name + " says, " + phrase);
       }
       //method "AddtwoIntegers
       public int AddTwoIntegers (int x, int y)
       {
          int Sum = x + y;
          Console.WriteLine(_name + " says the sum of 2+5 is " + (Sum));
          return Sum;
       }
    }
}
