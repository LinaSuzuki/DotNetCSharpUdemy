using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            //raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; //sbyte byte com sinal (num negativo)
            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Valor inteiro: " + menorValorInt);

            uint populacaoBrasileira = 207_287_273;//uint inteiro sem sinal
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador: " +precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //mais usados dos reais
            Console.WriteLine("Valor apple: " +valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas: " +distanciaEntreEstrelas);

            char letra = 'V'; //char entre aspas simples pois não é uma cadeia de caracteres
            Console.WriteLine("Letra: " +letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);
        }
    }
}
