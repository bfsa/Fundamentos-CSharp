namespace Exercicio07;

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("=======================");


        ContaBancaria conta = new ContaBancaria("João Silva");
        
        Console.WriteLine($"Titular: {conta.Titular}");
        
        conta.Depositar(500);
        conta.ExibirSaldo();

        Console.WriteLine($"Tentativa de saque: R$ 700,00");
        conta.Sacar(700); 

        conta.Sacar(200);
        conta.ExibirSaldo();
        
        Console.WriteLine($"Tentativa de depósito negativo: R$ -100,00");
        conta.Depositar(-100);
        
        conta.ExibirSaldo();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}