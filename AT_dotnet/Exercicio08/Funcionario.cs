namespace Exercicio08;

public class Funcionario {
    
    public string Nome { get; set; }
    public string Cargo { get; set; }
    protected decimal SalarioBase { get; set; }
    
    public Funcionario(string nome, string cargo, decimal salarioBase)
    {
        Nome = nome;
        Cargo = cargo;
        SalarioBase = salarioBase;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
        Console.WriteLine($"Salário Final: R$ {CalcularSalario():F2}");
    }
}