using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Solid.I.Violacao.Interfaces
{
    public interface ICorpoHumano
    {
        public void Andar() { }
        public void Comer() { }
        public void Pensar() { }
    };

    // Nota-se inválido, pois temos uma só interface geral com muitas responsabilidades.
    // Esse princípio se assemelha muito ao primeiro, mas voltado a interfaces.
}