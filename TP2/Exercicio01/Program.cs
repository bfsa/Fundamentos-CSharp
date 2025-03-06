namespace Exercicio01;

class Program {
    static void Main(string[] args) {

        Console.Write("Digite a sua data de nascimento (dd/mm/yyyy): ");
        string inputData = Console.ReadLine();
        
        if (DateTime.TryParse(inputData, out DateTime nascimento)) {

            DateTime hoje = DateTime.Today;

            int anos = hoje.Year - nascimento.Year;
            int meses = hoje.Month - nascimento.Month;
            int dias = hoje.Day - nascimento.Day;

            if (meses < 0 || (meses == 0 && dias < 0)) {
                anos--;
                meses += 12;
            }

            if (dias < 0) {
                meses--;
                dias += DateTime.DaysInMonth(hoje.Year, hoje.Month - 1);
            }

            Console.WriteLine($"Você tem {anos} ano(s), {meses} mese(s), {dias} dia(s).");


        } else {
            Console.WriteLine("Erro: Data de nascimento inválida.");
        }

}

}