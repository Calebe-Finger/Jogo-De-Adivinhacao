namespace JogoAdivinhacao.ConsoleApp
{
    internal class Program
    {
        //Versão 4: Implementar múltiplas tentativas

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Jogo de Adivinhação: ");
                Console.WriteLine("--------------------------------------");

                //Escolha de Dificuldade
                Console.WriteLine("Escolha um nível de dificuldade: ");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Médio (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");
                Console.WriteLine("--------------------------------------");

                string dificuldade = Console.ReadLine();

                int tentativas = 0;

                if (dificuldade == "1")
                    tentativas = 10;


                else if (dificuldade == "2")
                    tentativas = 5;

                else if (dificuldade == "3")
                    tentativas = 3;

                else
                    Console.WriteLine("Por favor, insira um número válido: ");

                //Escolha do número secreto
                Random geradorNumeros = new Random();

                int numeroSecreto = geradorNumeros.Next(1, 21);

                //Lógica do Jogo
                for (int tentativa = 1; tentativa <= tentativas; tentativa++)
                {
                    Console.Clear();

                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {tentativas}:");
                    Console.WriteLine("--------------------------------------");

                    Console.Write("Digite um número para chutar (de 1 á 20): ");

                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado > numeroSecreto)
                        Console.WriteLine("O número digitado é maior que o número secreto.");


                    else if (numeroDigitado < numeroSecreto)
                        Console.WriteLine("O número digitado é menor que o número secreto.");


                    else
                    {
                        Console.WriteLine("Parabéns, você acertou o número secreto!");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("Pressione ENTER para continuar: ");
                    Console.ReadLine();
                }

                //Escolha se deseja jogar novamente
                Console.WriteLine("Deseja jogar novamente (S/N): ");
                string jogarNovamente = Console.ReadLine().ToUpper();

                if (jogarNovamente != "S")
                    break;
            }
        }
    }
}
