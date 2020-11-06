using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            //o decremento antes da variável significa que você quer "Prioridade" (que está com pressa)
            //então será executado primeiro
            //fará a comparanção e a variável com incremento depois da variável, significa que não tem 
            //prioridade/sem pressa, então será executado após a comparação
            Console.WriteLine(numero1++ == --numero2); //true = 2 == 2

        }
    }
}
