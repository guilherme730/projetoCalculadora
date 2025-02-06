using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;
            int sub = num1 - num2;
            int multi = num1 * num2;
            int divisao = num1 / num2;


            Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
            Console.WriteLine($"A subtração de {num1} e {num2} é: {sub}");
            Console.WriteLine($"A multiplicação de {num1} e {num2} é: {multi}");
            Console.WriteLine($"A divisão de {num1} e {num2} é: {divisao}");


        }
    }
}
