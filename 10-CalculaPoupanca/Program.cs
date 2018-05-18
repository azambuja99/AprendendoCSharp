using System;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;

            //0.36% = 0.0036
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;

            //Console.WriteLine("Após 1 mês, você terá R$ " + valorInvestido);
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("Após " + contadorMes + " mês, você terá R$ " + valorInvestido.ToString("N2"));
                contadorMes++;
            }

            //for (int i = 1; i <= 12; i++)
            //{
            //    valorInvestido = valorInvestido + valorInvestido * 0.0036;

            //    Console.WriteLine("Após " + i + " mês, você terá R$ " + valorInvestido.ToString("N2"));
            //}

            Console.ReadLine();
        }
    }
}
