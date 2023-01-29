using System;

namespace JogoDeCavalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 100.00;

            while (saldo > 0)
            {
                Console.WriteLine("Seu saldo é de R$ " + saldo);
                Console.WriteLine("Escolha um cavalo (1, 2, 3, 4, 5) e valor de sua aposta");

                int cavaloEscolhido = int.Parse(Console.ReadLine());
                double valorAposta = double.Parse(Console.ReadLine());

                if (valorAposta > saldo)
                {
                    Console.WriteLine("Valor da aposta é maior que seu saldo, escolha outro valor");
                    continue;
                }

                Random random = new Random();
                int cavaloVencedor = random.Next(1, 5);

                if (cavaloEscolhido == cavaloVencedor)
                {
                    saldo += valorAposta * 5;
                    Console.WriteLine("Parabéns! Você acertou o cavalo vencedor. Seu saldo é agora de R$ " + saldo);
                }
                else
                {
                    saldo -= valorAposta;
                    Console.WriteLine("Que pena, você errou o cavalo vencedor. Seu saldo é agora de R$ " + saldo);
                }
            }
            Console.WriteLine("Seu saldo está zerado, game over");
        }
    }
}