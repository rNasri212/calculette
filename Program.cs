using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calculette
{
    internal class Program
    { /* methods
             */
         public static int add(int x, int y)
         { return x + y;  }
         public static int sub(int x, int y)
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
          /*declaration variablles
           */
            int x ;
            int y ;
            char op = '+';
            char userChoice;
            /* question utilisateur
             */
            do
            {
                Console.WriteLine("calculette");
                Console.WriteLine("premier chiffre ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("deuxieme chiffre ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add(+) Sous(-) Mult(*) Div(/)");
                op = Convert.ToChar(Console.ReadLine());
                /* ^switch 
                 * le switch serre a choisirre le tipe d'opération
                 */
                switch (op)
                {
                    case '+':
                        Console.WriteLine(add(x, y));
                        break;

                    case '-':
                        Console.WriteLine(sub(x, y));
                        break;

                    case '*':
                        Console.WriteLine(mul(x, y));
                        break;

                    case '/':
                        Console.WriteLine(div(x, y));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("Voulez-vous effectuer un autre calcul ? (O/N)");
                userChoice = Convert.ToChar(Console.ReadLine()); ;
            } while (userChoice == 'O' || userChoice == 'o');
            






        }
    }
}
