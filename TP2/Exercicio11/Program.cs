namespace Exercicio11;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("#### Tabuada Intrerativa ####");
        
        Console.Write("Digite um número para exibir a sua tabuada (1 a 10): ");
        int inputNum = int.Parse(Console.ReadLine());
        
        Console.WriteLine("#### Resultado ####");

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"{inputNum} x {i} = {inputNum * i}");
        }
    }
}