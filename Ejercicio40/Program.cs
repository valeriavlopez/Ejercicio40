using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    class Program
    {
        static void Main(string[] args)
        {
            int NN;
            Console.Write("Ingresar un Número para convertirlo en Romano: ");
            NN = Convert.ToInt32(Console.ReadLine());
            if (NN > 0 & NN <= 10)
            {
                switch (NN)
                {
                    case 1:
                        Console.WriteLine($"El valor { NN}  Es igual a I Romano");
                        break;
                    case 2:
                        Console.WriteLine($"El valor { NN} Es igual a II Romano");
                        break;
                    case 3:
                        Console.WriteLine($"El valor { NN} Es igual a III Romano");
                        break;
                    case 4:
                        Console.WriteLine($"El valor { NN} Es igual a IV Romano");
                        break;
                    case 5:
                        Console.WriteLine($"El valor { NN} Es igual a V Romano");
                        break;
                    case 6:
                        Console.WriteLine($"El valor {NN} Es igual a VI Romano");
                        break;
                    case 7:
                        Console.WriteLine($"El valor { NN} Es igual a VII Romano");
                        break;
                    case 8:
                        Console.WriteLine($"El valor {NN} Es igual a VIII Romano");
                        break;
                    case 9:
                        Console.WriteLine($"El valor { NN} Es igual a IX Romano");
                        break;
                    default:

                        Console.WriteLine($"El valor {NN} Es igual a I Romano");
                        break;

                }

            }
             else 
            {
                Console.WriteLine("La opción ingresada no está contemplada");
            }

            Console.ReadLine();


        }
    }
}
