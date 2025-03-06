namespace Exercicio06;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("#### Calculadora de IMC ####");
        Console.WriteLine("============================");
        Console.Write("Digite o seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Digite sua altura (ex: 1,78): ");
        double altura = double.Parse(Console.ReadLine());
        
        double imc = peso / (altura * altura);

        string categoria;
        
        switch (imc) {
            case double n when (n < 18.5):
                categoria = "Abaixo do Peso";
                break;
            case double n when (n >= 18.5 && n < 24.9):
                categoria = "Peso normal";
                break;
            case double n when (n >= 25 && n < 29.9):
                categoria = "Sobrepeso";
                break;
            case double n when (n >= 30 && n < 39.9):
                categoria = "Obesidade";
                break;
            default:
                categoria = "Obesidade grave";
                break;
        }
        Console.WriteLine("\n==== RESULTADO ====");
        Console.WriteLine("\nIMC = " + imc);
        Console.WriteLine("CATEGORIA = " + categoria);
        
        
    }
}