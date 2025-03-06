namespace Exercicio07;

class Program {
    static void Main(string[] args) {
        
        Console.WriteLine("#### Verificação de Pares ou Ímpares ####");
        
        Console.Write("Digite um número inteiro: ");
        int numeroInput = Int32.Parse(Console.ReadLine());

        if (numeroInput % 2 == 0) {
            Console.WriteLine($"O número {numeroInput} é par");
            return;
        }  
        
        Console.WriteLine($"O número {numeroInput} é ímpar");
        
    }
}