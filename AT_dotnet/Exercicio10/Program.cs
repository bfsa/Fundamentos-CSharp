namespace Exercicio10;

class Program {
    static void Main(string[] args) {
        var geradorAleatorio = new Random();
        var numeroSecreto = geradorAleatorio.Next(1, 51);

        var contadorTentativas = 0;

        var palpiteUsuario = ObterNumeroInteiro("Digite um número entre 1 e 50: ");

        var acertou = palpiteUsuario == numeroSecreto;
        while (!acertou && contadorTentativas < 4) {
            Console.WriteLine("O número está incorreto.");
            Console.WriteLine(
                $"Dica: O número correto é {(palpiteUsuario < numeroSecreto ? "maior que o seu" : "menor que o seu")}.");

            palpiteUsuario = ObterNumeroInteiro("Tente novamente:");
            contadorTentativas++;

            if (palpiteUsuario == numeroSecreto) {
                acertou = true;
            }
        }

        var mensagemFinal =
            acertou ? "Parabéns, você acertou!" : "Você perdeu, ultrapassou o numero maximo de tentativas.";
        Console.WriteLine(mensagemFinal);
    }

    private static int ObterNumeroInteiro(string mensagem) {
        Console.Write(mensagem);
        if (int.TryParse(Console.ReadLine() ?? "0", out var valor) && valor >= 1 && valor <= 50) {
            return valor;
        }

        Console.WriteLine("Valor inválido, tente novamente.");
        return ObterNumeroInteiro(mensagem);
    }
}