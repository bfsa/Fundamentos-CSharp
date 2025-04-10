namespace Exercicio08;

public class Gerente : Funcionario {

    private const decimal PERCENTUAL_BONUS = 0.20m;

    public Gerente(string nome, decimal salarioBase)
        : base(nome, "Gerente", salarioBase) {
    }

    public override decimal CalcularSalario() {
        decimal bonus = SalarioBase * PERCENTUAL_BONUS;
        return SalarioBase + bonus;
    }

    public override void ExibirDados() {
        base.ExibirDados();
        Console.WriteLine($"Bônus (20%): R$ {SalarioBase * PERCENTUAL_BONUS:F2}");
    }
}