using System.Globalization; // Adicionado para usar CultureInfo

namespace Exercicio04;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Calculadora de Dias até o Próximo Aniversário");
        Console.WriteLine("=============================================");

        DateTime dataNascimento = ObterDataNascimento();
        int diasAteAniversario = CalcularDiasAteProximoAniversario(dataNascimento);

        Console.WriteLine($"\nSua data de nascimento: {dataNascimento:dd/MM/yyyy}");

        if (diasAteAniversario == 0) {
            Console.WriteLine("\nHoje é seu aniversário! Parabéns! 🎂");
        }
        else if (diasAteAniversario < 7) {
            Console.WriteLine($"\nFaltam apenas {diasAteAniversario} dia(s) para seu aniversário! 🎉");
            Console.WriteLine("Prepare-se para comemorar!");
        }
        else {
            Console.WriteLine($"\nFaltam {diasAteAniversario} dias para seu próximo aniversário.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static DateTime ObterDataNascimento() {
        DateTime dataNascimento;
        bool entradaValida = false;

        do {
            Console.Write("\nDigite sua data de nascimento (DD/MM/AAAA): ");
            string entrada = Console.ReadLine();

            // Especificando para o formato brasileiro (dia/mês/ano)
            entradaValida = DateTime.TryParseExact(
                entrada,
                new[] {
                    "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy"
                }, // Professor, aqui testei alguns formatos aceitos
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dataNascimento);

            if (!entradaValida) {
                Console.WriteLine("Data inválida! Por favor, digite uma data no formato DD/MM/AAAA.");
            }
            else if (dataNascimento > DateTime.Today) {
                Console.WriteLine("A data de nascimento não pode ser no futuro!");
                entradaValida = false;
            }
        } while (!entradaValida);

        return dataNascimento;
    }

    static int CalcularDiasAteProximoAniversario(DateTime dataNascimento) {
        DateTime hoje = DateTime.Today;

        // Calcula a data do aniversário no ano atual
        DateTime aniversarioEsteAno = new DateTime(
            hoje.Year,
            dataNascimento.Month,
            Math.Min(DateTime.DaysInMonth(hoje.Year, dataNascimento.Month), dataNascimento.Day)
        );

        // Se o aniversário deste ano já passou, calcula para o próximo ano
        if (aniversarioEsteAno < hoje) {
            DateTime aniversarioProximoAno = new DateTime(
                hoje.Year + 1,
                dataNascimento.Month,
                Math.Min(DateTime.DaysInMonth(hoje.Year + 1, dataNascimento.Month), dataNascimento.Day)
            );

            return (aniversarioProximoAno - hoje).Days;
        }

        // Se o aniversário é hoje ou ainda vai ocorrer neste ano
        return (aniversarioEsteAno - hoje).Days;
    }
}