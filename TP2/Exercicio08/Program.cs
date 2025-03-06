namespace Exercicio08;

class Program {
    static void Main(string[] args) {
        
        Console.WriteLine("#### Classificador de Notas ####");
        Console.Write("Digite uma nota a ser classificada (0 a 10): ");
        string notaInput = Console.ReadLine();
        double nota;

        if (!double.TryParse(notaInput, out nota) || nota < 0 || nota > 10) {
            Console.WriteLine("Nota inválida: deve ser um número entre 0 e 10.");
            return;
        }

        string classificacao;

        if (nota < 5) {
            classificacao = "Insuficiente";
        } else if (nota >= 5 && nota < 7) {
            classificacao = "Regular";
        } else if (nota >= 7 && nota < 9) {
            classificacao = "Bom";
        } else {
            classificacao = "Excelente";
        }

        Console.WriteLine("#### Resultado ####");
        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
}