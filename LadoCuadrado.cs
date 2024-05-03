using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lado_Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Lado, Perimetro;
            string linea;
            Console.Write("Ingrese el lado del Cuadrado:");
            linea = Console.ReadLine();
            Lado = int.Parse(linea);
            Perimetro = Lado * 4;
            Console.Write("El Perimetro del cuadrado es:");
            Console.Write(Perimetro);
            Console.ReadKey();
        }
    }
}
