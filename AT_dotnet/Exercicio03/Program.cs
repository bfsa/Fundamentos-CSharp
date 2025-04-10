using System;

namespace Exercicio03;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Calculadora de Operações Matemáticas");
        Console.WriteLine("===================================");

        double numero1;
        bool entradaValida = false;

        do {
            Console.Write("\nDigite o primeiro número: ");
            string entrada = Console.ReadLine();

            entradaValida = double.TryParse(entrada, out numero1);

            if (!entradaValida) {
                Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
            }
        } while (!entradaValida);


        double numero2;
        entradaValida = false;

        do {
            Console.Write("Digite o segundo número: ");
            string entrada = Console.ReadLine();

            entradaValida = double.TryParse(entrada, out numero2);

            if (!entradaValida) {
                Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
            }
        } while (!entradaValida);

        Console.WriteLine("\nEscolha a operação desejada:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");

        // Seleção da operação com validação
        int operacao;
        entradaValida = false;

        do {
            Console.Write("\nDigite o número da operação (1-4): ");
            string entrada = Console.ReadLine();

            entradaValida = int.TryParse(entrada, out operacao) && operacao >= 1 && operacao <= 4;

            if (!entradaValida) {
                Console.WriteLine("Opção inválida! Por favor, digite um número entre 1 e 4.");
            }
        } while (!entradaValida);

        // Calcula e exibe o resultado da operação escolhida
        double resultado = 0;
        string nomeOperacao = "";

        switch (operacao) {
            case 1:
                resultado = numero1 + numero2;
                nomeOperacao = "Soma";
                break;

            case 2:
                resultado = numero1 - numero2;
                nomeOperacao = "Subtração";
                break;

            case 3:
                resultado = numero1 * numero2;
                nomeOperacao = "Multiplicação";
                break;

            case 4:
                if (numero2 == 0) {
                    Console.WriteLine("\nErro: Não é possível dividir por zero!");
                    Console.WriteLine("\nPressione qualquer tecla para sair...");
                    Console.ReadKey();
                    return;
                }

                resultado = numero1 / numero2;
                nomeOperacao = "Divisão";
                break;
        }

        Console.WriteLine($"\nResultado da {nomeOperacao}: {resultado}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}