namespace Upper.Solid.D.Solucao
{
    public class CorpoHumano
    {
        private readonly IRespirador _respirador;

        public CorpoHumano(IRespirador respirador)
        {
            _respirador = respirador;
        }
        // Agora podemos substituir por qualquer outra implementação necessária.
        // Exemplo disso no "Main.cs"

        public void Viver() { _respirador.Respirar(); }
    };

    public interface IRespirador
    {
        public void Respirar() { }
    };

    public class PulmaoArtificial : IRespirador
    {
        public void Respirar() { }
    };

    public class Pulmao : IRespirador
    {
        public void Respirar() { }
    }

} // Nota-se correto, porque temos um módulo de alto nível e um detalhe dependendo de uma abstração.
