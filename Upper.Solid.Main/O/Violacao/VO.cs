namespace Upper.Solid.O.Violacao
{
    public class CalculadoraV1
    {
        public required string Operador { get; set; }
        public required int Numero1 { get; set; }
        public required int Numero2 { get; set; }

        public int Calcular()
        {
            if (Operador == "+") { return Numero1 + Numero2; }
            else if (Operador == "-") { return Numero1 - Numero2; }
            else if (Operador == "*") { return Numero1 * Numero2; }
            else if (Operador == "*") { return Numero1 / Numero2; }
            else { Console.Write("Digite um operador válido!"); return 0; }
        }
    }

    public class CalculadoraV2
    {
        public required string Operador { get; set; }
        public required double Numero1 { get; set; }
        public required double Numero2 { get; set; }

        public double Calcular()
        {
            if (Operador == "+") { return Numero1 + Numero2; }
            else if (Operador == "-") { return Numero1 - Numero2; }
            else if (Operador == "*") { return Numero1 * Numero2; }
            else if (Operador == "*") { return Numero1 / Numero2; }
            else if (Operador == "**") { return Math.Pow(Numero1, Numero2); }
            else { Console.Write("Digite um operador válido!"); return 0; }
        }
    }

    // Nota-se erro, pois para adicionar uma nova funcionalidade a classe Calculadora,
    // teve-se que alterar a lógica interna do método, além de violar o primeiro princípio.
}