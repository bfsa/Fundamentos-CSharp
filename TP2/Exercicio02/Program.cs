namespace Exercicio02;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite sua data de nascimento (dd/mm/yyyy): ");
        string inputData = Console.ReadLine();

        if (DateTime.TryParse(inputData, out DateTime nascimento)) {

            DateTime hoje = DateTime.Today;
            DateTime aniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

            if (aniversario < hoje) {
                aniversario = aniversario.AddYears(1);
            }
            
            TimeSpan diferenca = aniversario - hoje;
            
            Console.WriteLine($"Faltam {diferenca.Days} dias para seu próximo aniversário.");
    }
    }
}