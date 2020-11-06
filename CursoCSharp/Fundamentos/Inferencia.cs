using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo";
            //nome = 123;
            Console.WriteLine(nome);

            //int idade;
            var idade = 12;
            Console.WriteLine("Idade: " +idade);

            int a;
            a = 23;

            int b = 2;
            Console.WriteLine(a+b);
        }
    }
}
