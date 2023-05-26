using Ejercicio1.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
    
    public void PedriDatos()
        {
            Console.WriteLine("Ingresa tu nombre: ");
            this.Nombre=Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            this.Apellido=Console.ReadLine();
            Console.WriteLine("Ingresa tu Carrera: ");
            this.Carrera=Console.ReadLine();
            Console.WriteLine("Ingresa tu Edad: ");
            this.Edad = int.Parse(Console.ReadLine());

            Console.Clear();

            if(Edad >= 18)
            {
                Menu menu = new Menu();
                menu.Opciones();

            }
            else
            {
                Console.WriteLine("No puedes acceder :(");
            }
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Carrera: " + Carrera);
            Console.WriteLine("Edad: " + Edad);
        }
    }

}
