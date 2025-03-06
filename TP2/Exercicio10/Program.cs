using System.Collections;

namespace Exercicio10;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("#### Contagem Regressiva ####");
        Console.Write("Digite o número inicial da contagem: ");
        int inputNum = int.Parse(Console.ReadLine());
        Console.Write("Digite o número inicial da contagem: ");

        for (int i = inputNum; i >= 0; i--) {
            if (i > 0) Console.Write($"{i}, ");
            else Console.Write($"{i}.");
        }
    }
}