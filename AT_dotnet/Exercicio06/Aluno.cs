namespace Exercicio06;

public class Aluno {
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public double Media { get; set; }

    public Aluno(string nome, string matricula, string curso, double media) {
        Nome = nome;
        Matricula = matricula;
        Curso = curso;
        Media = media;
    }

    public void ExibirDados() {
        Console.WriteLine("---- DADOS DO ALUNO ----");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Média: {Media:F2}");
        Console.WriteLine($"Situação: {VerificarAprovacao()}");
        Console.WriteLine("=====================");
    }

    public string VerificarAprovacao() {
        return Media >= 7 ? "Aprovado" : "Reprovado";
    }
}