using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper.Solid.L.Solucao
{
    public interface ICozinheiro
    {
        public void Cozinhar() { }
    };

    public class Cozinheiro : ICozinheiro
    {
        public void Cozinhar() { }
    }
    public class ChefeCozinha : ICozinheiro
    {
        public void Liderar() { }
    };

    // Nota-se válido, pois tanto o Cozinheiro quanto o chefe de cozinha podem substituir
    // tranquilamente suas "classe-pai", além de respeitar os 2 primeiros princípios.
}