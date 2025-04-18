namespace JogoAdivinhacao.ConsoleApp
{
    internal class Program
    {
        //Versão 2: Gerar um número secreto aleatório

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Jogo de Adivinhação: ");
            Console.WriteLine("-----------------------------");

            //Lógica do Jogo

            Random geradorNumeros = new Random();

            int numeroSecreto = geradorNumeros.Next(1, 21);

            Console.Write("Digite um número para churar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado > numeroSecreto) 
            {
                Console.WriteLine("O número digitado é maior que o número secreto.");
            }

            else if (numeroDigitado < numeroSecreto)
            {
                Console.WriteLine("O número digitado é menor que o número secreto.");
            }

            else
            {
                Console.WriteLine("Parabéns, você acertou o número secreto!");
            }

            Console.ReadLine();
        }
    }
}
