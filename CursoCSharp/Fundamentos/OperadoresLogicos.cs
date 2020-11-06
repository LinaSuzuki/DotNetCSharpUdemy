using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            Console.WriteLine("Recebeu pelo primeiro trabalho? ");
            bool.TryParse(Console.ReadLine(), out bool trabalho1);
            Console.WriteLine("Recebeu pelo segundo trabalho? ");
            bool.TryParse(Console.ReadLine(), out bool trabalho2);

            bool comprouTv50 = trabalho1 && trabalho2;
            Console.WriteLine("Comprou a TV de 50? {0}.", comprouTv50);

            var comprouSorvete = trabalho1 || trabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = trabalho1 ^ trabalho2;
            Console.WriteLine("Compro a TV de 32? {0}.", comprouTv32);

            Console.WriteLine("Mais saudável? {0}.", comprouSorvete);
        }
    }
}
