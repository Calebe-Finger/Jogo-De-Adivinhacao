namespace JogoAdivinhacao.ConsoleApp
{
    internal class Program
    {
        //Versão 1: Estrutura básica e entrada do usuário

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Jogo de Adivinhação: ");
            Console.WriteLine("-----------------------------");

            //Lógica do Jogo
            Console.Write("Digite um número para churar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Você digitou o número: " + numeroDigitado);

            Console.ReadLine();
        }
    }
}
