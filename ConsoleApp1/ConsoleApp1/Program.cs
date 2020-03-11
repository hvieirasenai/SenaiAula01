using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            Console.WriteLine(" Ola Mundo !!");
            Console.WriteLine(" Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine(" Ola Mundo ! Eu sou o " + nome);
            Console.ReadLine();

        }
    }
}
