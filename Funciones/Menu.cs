using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Funciones
{
    public class Menu
    {
        public void Opciones()
        {
            Console.WriteLine("Ingrese una de las opciones: ");
            Console.WriteLine("1: Suma");
            Console.WriteLine("2: Resta");
            Console.WriteLine("3: Multiplicacion");
            Console.WriteLine("4: Dolar a pesos");

            int opcion = int.Parse(Console.ReadLine());

            Operaciones operacion = new Operaciones();

            Console.Clear();
            

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el primer valor: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa otro valor:");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el primer valor: ");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa otro valor:");
                    int num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el primer valor: ");
                    int num5 = int.Parse(Console.ReadLine());
                    
                    int result=operacion.Suma(num1, num2, num3, num4, num5);
                    Console.WriteLine("El resultado es: "+result);
                    break;

                case 2:
                    Console.WriteLine("Ingresa el primer valor: ");
                    int nume1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa otro valor:");
                    int nume2 = int.Parse(Console.ReadLine());

                    result = operacion.Resta(nume1, nume2);
                    Console.WriteLine("El resultado es: " + result);
                    break;
                case 3:
                    Console.WriteLine("Ingresa el primer valor: ");
                    int numr1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa otro valor:");
                    int numr2 = int.Parse(Console.ReadLine());

                    result = operacion.Multi(numr1, numr2);
                    Console.WriteLine("El resultado es: " + result);
                    break;
                case 4:
                    Console.WriteLine("Ingresa " +
                        "la cantidad de sus dolares: ");
                    int numer1 = int.Parse(Console.ReadLine());
                    
                    result = operacion.DaP(numer1);
                    Console.WriteLine("Sus pesos son: "+ result);
                    break;

                default:
                    Console.WriteLine("Esa opcion no exite :(");
                    break;

            }
        }
 
    }
}
