using System.Text;
using System;

namespace Exercicio02;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cifrador de Nome - Deslocamento de 2 posições");
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            string nomeCifrado = CifrarNome(nome);

            Console.WriteLine("\nNome original: " + nome);
            Console.WriteLine("Nome cifrado: " + nomeCifrado);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        static string CifrarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return string.Empty;

            char[] caracteres = nome.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                char c = caracteres[i];

                // Ignorar espaços
                if (c == ' ')
                    continue;

                // Deslocar letras maiúsculas
                if (c >= 'A' && c <= 'Z')
                {
                    c = (char)((c - 'A' + 2) % 26 + 'A');
                }
                // Deslocar letras minúsculas
                else if (c >= 'a' && c <= 'z')
                {
                    c = (char)((c - 'a' + 2) % 26 + 'a');
                }

                caracteres[i] = c;
            }

            return new string(caracteres);
        }
    }