using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upper.Solid.I.Violacao.Interfaces;

namespace Upper.Solid.I.Violacao.Models
{
    public class CorpoHumano : ICorpoHumano
    {
        public void Andar() { }
        public void Comer() { }
        public void Pensar() { }
    }

    // Uso inadequado da implementação de interfaces e classes contra esse princípio -
    // uma classe geral fazendo tudo. Desrespeitando alguns princípios anteriores.
}
