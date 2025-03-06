namespace Exercicio12;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("#### Jogo de Adivinhação ####");
        Console.WriteLine("Tente adivinhar o número correto entre 1 e 100!");
        
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        
        bool acertou = false;
        int tentativa = 0;
        int palpite = 0;

        while (!acertou) {
            tentativa++;
            
            Console.Write($"[Tentativa {tentativa}] Digite seu palpite: ");

            try {
                palpite = int.Parse(Console.ReadLine());
            }
            catch (FormatException) {
                Console.WriteLine("Palpite inválido! Digite um número entre 1 e 100!");
                tentativa--;
                continue;
            }

            if (palpite == numeroAleatorio) {
                acertou = true;
                Console.WriteLine($"\n\ud83c\udf89 Parabéns! Você acertou o número {numeroAleatorio} em {tentativa} tentativas!");
            } else if (palpite > numeroAleatorio) {
                Console.WriteLine("Tente um número MENOR!");
            } else {
                Console.WriteLine("Tente um número MAIOR!");
            }
        }
    }
}