namespace Exercicio09;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("#### Calculadora de Salário Líquido ####");
        
        Console.Write("Digite seu salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        double salarioLiquido;
        double desconto;

        if (salarioBruto <= 2000) {
            desconto = salarioBruto * 0.05;
        } else if (salarioBruto <= 5000) {
            desconto = salarioBruto * 0.10;
        } else if (salarioBruto <= 10000) {
            desconto = salarioBruto * 0.15;
        } else {
            desconto = salarioBruto * 0.20;
        }
        
        salarioLiquido = salarioBruto - desconto;
        
        Console.WriteLine("\n#### Resultados ####");
        Console.WriteLine($"\nSalário Bruto: R${salarioBruto:F2}");
        Console.WriteLine($"Desconto: R${desconto:F2}");
        Console.WriteLine($"Salário Liquido: R${salarioLiquido:F2}");
        


    }
}