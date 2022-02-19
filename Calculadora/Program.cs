using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        /* *, /, +, -, sqrt, ^ */
        static void Main(string[] args)
        {
            string op = "suma";
            Operaciones operacion = new Operaciones();
            while (op != "salir")
            {
                
                Console.WriteLine("Cuanto valores vas a ingresar");
                int valores = Convert.ToInt32(Console.ReadLine());
                if(valores == 1)
                {
                    Console.WriteLine("Ingresa el valor");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" La raiz cuadrada de " + valor1 + " = " +operacion.Operacion(valor1));
                }
                else if(valores == 2)
                {
                    Console.WriteLine("Ingresa el valor 1");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor 2");
                    double valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa la operacion suma, resta, multiplicacion, division, potencia");
                    op = Console.ReadLine();
                    Console.WriteLine(" La " + op + " de " + valor1 + " y " + valor2 + " = " + operacion.Operacion(valor1, valor2, op));
                }
            }
        }
    }
}
