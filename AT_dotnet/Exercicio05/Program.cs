using System;

namespace Exercicio05;

class Program {
    static void Main(string[] args) {
        // Data de formatura definida no código
        DateTime dataFormatura = new DateTime(2026, 12, 15);

        // Solicitar ao usuário a data atual
        Console.Write("Digite a data atual (DD/MM/AAAA): ");
        string input = Console.ReadLine();

        // Tentar converter a data fornecida pelo usuário usando o System.Globalization
        DateTime dataAtual;
        if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None,
                out dataAtual)) {
            Console.WriteLine("Erro: A data informada está em formato inválido.");
            return;
        }

        // Verificar se a data atual é no futuro
        if (dataAtual > DateTime.Now) {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        // Calcular a diferença entre a data de formatura e a data atual
        if (dataAtual > dataFormatura) {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
        }
        else {
            // Calcular a diferença entre as datas
            int anos = dataFormatura.Year - dataAtual.Year;
            int meses = dataFormatura.Month - dataAtual.Month;
            int dias = dataFormatura.Day - dataAtual.Day;

            // Ajustar caso a diferença de meses ou dias seja negativa
            if (dias < 0) {
                meses--;
                dias += DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            }

            if (meses < 0) {
                anos--;
                meses += 12;
            }

            // Exibir o tempo restante para a formatura
            if (anos > 0 || meses > 0 || dias > 0) {
                Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
            }

            // Exibir mensagem especial se faltar menos de 6 meses
            if (anos == 0 && meses < 6) {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
    }
}