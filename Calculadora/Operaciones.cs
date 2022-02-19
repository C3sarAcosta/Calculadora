using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operaciones
    {
        /* *, /, +, -, sqrt, ^ */
        public double resultado { get; set; }

        public Operaciones()
        {
            this.resultado = 0;
        }
        
        public double Operacion(double valor1)
        {
            resultado = Math.Sqrt(valor1);
            return resultado;
        }

        public double Operacion(double numero1, double numero2, string operacion)
        {
            switch (operacion)
            {
                case "suma":
                    resultado = numero1 + numero2;
                    break;
                case "resta":
                    resultado = numero1 - numero2;
                    break;
                case "multiplicacion":
                    resultado = numero1 * numero2;
                    break;
                case "division":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
                case "ptencia":
                    resultado = Math.Pow(numero1, numero2);
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }

        public double Operacion(double numero1, double numero2, double numero3, string operacion)
        {
            switch(operacion)
            {
                case "suma":
                    resultado = numero1 + numero2 + numero3;
                    break;
                case "resta":
                    resultado = numero1 - numero2 - numero3;
                    break;
                case "multiplicacion":
                    resultado = numero1 * numero2 * numero3;
                    break;
                default:
                    resultado= 0;
                    break;
            }
            return resultado;
        }
    }
}
