using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey();
            
        }
        static void ejer1()
        {
            string nombre, carrera; //declarando variables

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");

        }
        static void ejer2()
        {
            Console.WriteLine("\"choi\"");

            ejer3();
        }
        static void ejer3()
        {
            Console.Write("Ingrese numero x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double resu = x / y;

            Console.WriteLine("Suma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicacion: " + (x * y));
            Console.WriteLine("Division: " + resu);

            ejer4();
        }
        static void ejer4()
        {
            Console.Write("Ingrese un numero decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());  

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num ,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1 / 3d);

            Console.WriteLine("Raiz 2: " + raiz2);
            Console.WriteLine("Redondeando: " + redo);
            Console.WriteLine("Al cubo " + cubo);
            Console.WriteLine("Raiz 3: " + raiz3);

        }
        static void ejer5()
        {

        }
    }
}
