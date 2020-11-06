using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.Estrutura_de_controle;

namespace CursoCSharp {
    class Program 
    {
        static void Main(string[] args) 
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() 
            {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando números - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadores ternário - Fundamentos", OperadorTernario.Executar },
                //ESTRUTURAS DE CONTROLE
                {"Estrutura If - Fundamentos", EstruturaIf.Executar },
                {"Estrutura If Else - Fundamentos", EstruturaIfElse.Executar },
                {"Estrutura If Else If - Fundamentos", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Fundamentos", EstruturaSwitch.Executar },
                {"Estrutura While - Fundamentos", EstruturaWhile.Executar },
                {"Estrutura Do While - Fundamentos", EstruturaDoWhile.Executar },
                {"Estrutura For - Fundamentos", EstruturaFor.Executar },
                {"Estrutura Foreach - Fundamentos", EstruturaForeach.Executar },
                {"Usando Break - Fundamentos", UsandoBreak.Executar },
                {"Usando Continue - Fundamentos", UsandoContinue.Executar },
            });
            central.SelecionarEExecutar();
        }
    }
}