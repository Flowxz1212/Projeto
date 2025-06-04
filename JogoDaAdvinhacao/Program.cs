// See https://aka.ms/new-console-template for more information

using System;

Random random = new Random();
int NumeroSecreto = random.Next(1, 101);
int Palpite = 0;
int tentativas = 0;

while (Palpite != NumeroSecreto)
{
    Console.WriteLine("Digite Um Número entre 1 e 100");

    string input = Console.ReadLine();

    if (int.TryParse(input, out Palpite))
    {
        tentativas++;

        if (Palpite < NumeroSecreto)
        {
            Console.WriteLine("Muito Baixo");
        }
        else if (Palpite == NumeroSecreto)
        {
            Console.WriteLine("Parabéns! Você acertou!");
            Console.WriteLine(Convert.ToString(tentativas));
        }
        else 
        {
            Console.WriteLine("Muito Alto");
        }
    }

    else
    {
        Console.WriteLine("Digite um Número entre 1 e 100, Cabeçudo");

    }
    
}
/*

using System;

class Program
{
    static void Main()
    {
        // Gerar um número aleatório entre 1 e 100.
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int palpite = 0; // Inicializa o palpite com um valor que não é o número secreto.

        // Enquanto o palpite for diferente do número secreto, continue o loop.
        while (palpite != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            string input = Console.ReadLine();

            // Verifica se a entrada do usuário pode ser convertida para inteiro.
            if (int.TryParse(input, out palpite))
            {
                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo!");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Muito alto!");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }
}
*/
