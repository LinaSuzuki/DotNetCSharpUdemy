using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, "Mundo").Replace("Mundo", "World");
            Console.WriteLine(saudacao);

            Console.WriteLine("Testes".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante.Length);
        }
    }
}
