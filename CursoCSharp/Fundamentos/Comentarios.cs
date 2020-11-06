using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Comentarios
    {
        /// <summary>
        /// Colocando 3 barras, gera tag xml para que gere documentação automaticamente (xml coments)
        /// </summary>
        public static void Executar()
        {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor");

            /* Comentários
             * de múltiplas
             * linhas
             */
            Console.WriteLine("O C# tem o XML Coments");

            //Console.WriteLine("1");
            //Console.WriteLine("2");
        }
    }
}
