using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // uma casa decimal
            Console.WriteLine(valor.ToString("C")); // C de currency moeda
            Console.WriteLine(valor.ToString("P")); // P porcentagem
            Console.WriteLine(valor.ToString("#.##")); // Máscara

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura)); // C moeda com 0 casa decimal = moeda Brasil

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
