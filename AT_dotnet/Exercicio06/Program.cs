namespace Exercicio06;

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Sistema de Cadastro de Alunos");
        Console.WriteLine("============================");

        Aluno alunaTeste = new Aluno(
            "Fulana da Silva",
            "2023001",
            "Engenharia de Software",
            8.5);

        alunaTeste.ExibirDados();


        Aluno alunoTeste = new Aluno(
            "Ciclano dos Santos",
            "2023002",
            "Ciência da Computação",
            6.5);

        alunoTeste.ExibirDados();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}