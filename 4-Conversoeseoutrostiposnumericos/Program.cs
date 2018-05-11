using System;

namespace _4_Conversoeseoutrostiposnumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // O int e um tipo de variavel que suporta valores ate 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long e uma variavel de 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // O short e um tipo de variavel que suporta 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);
            float altura = 1.80f;
            Console.WriteLine(altura);
            decimal peso = 60.2m;
            Console.WriteLine(peso);

            Console.WriteLine("Fim Da Execução...............");
            Console.ReadLine();
        }
    }
}
