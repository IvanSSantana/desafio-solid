using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Solid.S.Violacao
{
    public class Cozinheiro
    {
        public void Cozinhar() { }
        public void AnotarPedidos() { }
        public void Limpar() { }

        // Nota-se a violação quando a classe "Cozinheiro" é responsável por várias coisas ao mesmo tempo
    }
}