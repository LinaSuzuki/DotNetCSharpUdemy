﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            //preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço final é {0}.", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);//Pow = potência
            Console.WriteLine("IMC é {0}", imc);

            //número par ou ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0} / 2 tem resto {1}. ", par, par % 2);
            Console.WriteLine("{0} / 2 te resto {1}. ", impar, impar % 2);
        }
    }
}