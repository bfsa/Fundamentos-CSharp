namespace Exercicio08;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Sistema de Cadastro de Funcionários");
        Console.WriteLine("==================================");
        
        Funcionario funcionario = new Funcionario("Fulano da Silva", "Analista", 3000.00m);
        
        Gerente gerente = new Gerente("Ciclana dos Santos", 5000.00m);
        
        Console.WriteLine("\n=== DADOS DO FUNCIONÁRIO ===");
        funcionario.ExibirDados();
        
        Console.WriteLine("\n=== DADOS DO GERENTE ===");
        gerente.ExibirDados();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}