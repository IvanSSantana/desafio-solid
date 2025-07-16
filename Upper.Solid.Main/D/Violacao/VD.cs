namespace Upper.Solid.D.Violacao
{
    public class Pulmao
    {
        public void Respirar() { }
    };

    public class CorpoHumano
    {
        Pulmao pulmao = new();

        public void Viver() { }
    }
} // Nota-se violado, porque temos um módulo de alto nível (Corpo) dependendo
  // de um módulo de baixo nível (Coração). Caso quiséssemos alterar algo, seria necessário
  // vir no código-fonte, ferindo também o princípio OCP.
