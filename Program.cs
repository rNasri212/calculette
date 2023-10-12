using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calculette
{
    internal class Program
    {
        public static int add(int x, int y)
        { return x + y;  }
        public static int sus(int x, int y)
        { return x - y; }
        public static int mul(int x, int y)
        { return x * y; }
        public static int div(int x, int y)
        { return x / y; }
        static void Main(string[] args)
        /* Rayan Nasri
            * etml¨
            * projet stge 2 calculette
            * 10.10.2023
            */
        {
          
            int x ;
            int y ;
            char op = '+';

            Console.WriteLine("calculette"); 
            Console.WriteLine("premier chiffre ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("deuxieme chiffre ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add(+) Sous(-) Mult(*) Div(/)");
            op = Convert.ToChar(Console.ReadLine());
           
            switch(op)
            {
                case '+':
                    Console.WriteLine(add(x, y));
                    break;

                case '-':
                    Console.WriteLine(sus(x, y));
                    break;

                case '*':
                    Console.WriteLine(mul(x, y));
                    break;

                case '/':
                    Console.WriteLine(div(x, y));
                    break;
                default: Console.WriteLine("error");
                    break;           
            }
            Console.ReadKey();






        }
    }
}
