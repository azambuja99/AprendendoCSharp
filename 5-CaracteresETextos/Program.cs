using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //character 
            char primeiraletra = 'a';

            Console.WriteLine(primeiraletra);

            primeiraletra = (char)61;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string titulo = "Alura cursos de tecnologia  " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = @"- .NET 
- Java 
- JavaScript";
            Console.WriteLine(cursosProgramacao);



            Console.ReadLine();
        }
    }
}
