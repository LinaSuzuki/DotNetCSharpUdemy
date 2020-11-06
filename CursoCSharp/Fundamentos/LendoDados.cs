using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome} tem {idade} e ganha R$ {salario}");
        }
    }
}
