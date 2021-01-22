using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            bool condition = false;
            char character = 'A';

    
            int number1 = 2147483647;
            long number2 = 2147483648;
            short number3 = 32767;
            byte number4 = 255;
            double number5 = 1.5;
            decimal number6 = 10.4m;

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0},",number3);
            Console.WriteLine("Number4is {0},", number4);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Number5 is {0},", number5);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();


            
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday
   }
}
