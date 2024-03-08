// See https://aka.ms/new-console-template for more information
using System;
namespace DeclarandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipo e nome
            // posso colocar o valor assim que declaro a variavel caso eu souber
            int idade;
            decimal altura;
            string nome;

            nome = "Agnos";
            altura = 1.70m;
            idade = 31;
            Console.WriteLine("Olá " +nome);
            Console.WriteLine("Você tem, " +idade);
            Console.WriteLine("e tem, " +altura);
        }
    }
}


