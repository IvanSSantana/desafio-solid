using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Solid.O.Solucao
{
    public abstract class Cálculos
    {
        public required string Operador { get; set; }
        public required int Numero1 { get; set; }
        public required int Numero2 { get; set; }

        public abstract double Calcular(string op, double n1, double n2);

        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtração(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicação(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divisão(double n1, double n2)
        {
            return n1 / n2;
        }

        // Eu posso extender as classes somente adicionando, sem alterar lógicas anteriores.
        public double Potenciação(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
    }

    public class Calculadora : Cálculos
    {
        public override double Calcular(string op, double n1, double n2)
        {
            switch (op)
            {
                case "+":
                    return Soma(n1, n2);
                case "-":
                    return Subtração(n1, n2);
                case "*":
                    return Multiplicação(n1, n2);
                case "/":
                    return Divisão(n1, n2);
                default:
                    Console.WriteLine("Houve um erro durante o cálculo.");
                    return 0.0;
            }
        }
    }

    // Nota-se válido, pois para adicionar uma nova funcionalidade a classe Calculadora,
    // apenas extendemos ela, adicionando um novo case e um novo cálculo,
    // sem precisar alterar a lógica anterior.
    // E ainda corrigimos a violação do primeiro princípio.
}