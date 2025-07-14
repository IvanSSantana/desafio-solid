using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Solid.L.Violacao
{
    public class Soma
    {
        public virtual double Calcular(double n1, double n2) { return n1 + n2; }
    };

    public class Subtração : Soma
    {
        public override double Calcular(double n1, double n2) { return n1 - n2; }
    };

    // Nota-se inválido, pois subtração acabou modificando a função original, desrespeitando o segundo
    // e o terceiro princípio, pois agora não mais soma nem substitui o pai. 
    // É um exemplo bem errado, mas ilustra o que é proposto.
}