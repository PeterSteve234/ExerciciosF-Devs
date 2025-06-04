// calculadora e c#
/*
Estrutura de uma calculadora no console em C#:
Exibe um menu de operações
(adição, subtração, multiplicação, divisão, sair)

Recebe a escolha do usuário

Pede os dois números (operandos)

Executa a operação baseada na escolha

Mostra o resultado

Repete até o usuário escolher sair
*/

using System;
 
 class calculadora
 {
    static void Main()
    {
        Console.WriteLine("Digite o primeiro numero");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite um operador (+ - * /)");
        char operador = Console.ReadKey().KeyChar;

        Console.WriteLine("Digite um segundo numero");
        double numero2 = Convert.ToDouble(Console.ReadLine()); // OBS: -> sendo estudado 


        double resultado = 0;


        switch (operador)
        {
            case '+':
                resultado = numero1 + numero2;
                  break;
            case '-':
                resultado = numero1 + numero2;
                  break;
            case '*':
                resultado = numero1 * numero2;
                  break;
            case '/':
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Erro: Impossivel realizar a disisão por zero");
                    return;
                }
                  break;
                   default:
                  Console.WriteLine("Erro: Operador inválido");
                return;

        }

        Console.WriteLine($"Resultado: {resultado}");
    }
     
 }
