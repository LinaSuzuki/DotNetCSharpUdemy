using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversão implícita
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro; // double é maior que int, por isso que int cabe em double. Conversão feita implicítamente
            Console.WriteLine(quebrado);

            // Conversão explícita
            double nota = 9.7;
            //int notaTruncada = nota; //double não cabe em int porque int tem a capacidade menor. Dessa forma dá mensagem de que não é possível converter double implicitamente para double
            int notaTruncada = (int)nota; // conversão explícita de double para int
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            // Convertendo string para inteiro com int.Parse
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida foi: {idadeInteiro}");

            // Convertendo string para inteiro com Convert
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            // Convertendo string para inteiro com TryParse
            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Resultado 1: {numero1}");

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2); //tenta converter, criou a var numero2 já jogando o valor digitado na variavel
            Console.WriteLine($"Resultado 2: {numero2}");


        }
    }
}
