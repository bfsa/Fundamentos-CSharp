namespace Exercicio04;

class Program {
    static void Main(string[] args) {
        
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite sua idade: ");
        int idade = Int32.Parse(Console.ReadLine());
        
        Console.Write("Digite seu telefone: ");
        string telefone = Console.ReadLine();
        
        Console.Write("Digite seu e-mail: ");
        string email = Console.ReadLine();
        
        Console.WriteLine("\n ---- Dados do Cadastro ----");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Telefone: " + telefone);
        Console.WriteLine("E-mail: " + email);
        
    }
}