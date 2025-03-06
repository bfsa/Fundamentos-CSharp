using System;

namespace Exercicio03
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("--- Calculadora de diferença entre datas ---");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Digite a primeira data (dd/mm/yyyy): ");
            string inputData1 = Console.ReadLine();
            Console.Write("Digite a segunda data (dd/mm/yyyy): ");
            string inputData2 = Console.ReadLine();

            if (DateTime.TryParse(inputData1, out DateTime data1) &&
                DateTime.TryParse(inputData2, out DateTime data2)) {

                if (data1 > data2) {
                    DateTime temp = data1;
                    data1 = data2;
                    data2 = temp;
                    Console.WriteLine("Ordem das datas reordenadas para calcular corretamente.");
                }

                TimeSpan diferenca = data2 - data1;
                int totalDias = (int)diferenca.TotalDays;

                int anos = 0;
                int meses = 0;
                int dias = 0;

                DateTime dataTemp = data1;

                while (dataTemp.AddYears(1) <= data2) {
                    anos++;
                    dataTemp = dataTemp.AddYears(1);
                }

                while (dataTemp.AddMonths(1) <= data2) {
                    meses++;
                    dataTemp = dataTemp.AddMonths(1);
                }
                
                dias = (data2 - dataTemp).Days;
                
                Console.WriteLine("\n=== RESULTADO ===");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Diferença total em dias: {totalDias} dias");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Diferença detalhada:");
                Console.WriteLine($"{anos} ano(s), {meses} mes(es) e {dias} dia(s)");
            }
        }
    }
}
