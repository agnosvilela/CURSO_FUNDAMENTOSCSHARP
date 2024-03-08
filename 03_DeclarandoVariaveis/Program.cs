// See https://aka.ms/new-console-template for more information
using System;
namespace DeclarandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipo e nome
            // posso declarar assim que declaro a variavel
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


