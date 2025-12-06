using POOCalcMedia;
using System;

namespace CalcutorMedia
{
    class Program
    {
        static void Main()
        {

            string continuar = "S";

            // Loop principal do programa
            do
            {
                // Apresentação do programa
                Funcoes.Apresentacao();

                // Obter as notas do aluno
                ObterNotaAluno obterNotas = new ObterNotaAluno();
                CalcularMediaAluno calcular = new CalcularMediaAluno();

                // Chama o método para obter as notas
                obterNotas.ObterNotas();

                // Calcula a média
                double media = calcular.CalcularMedia(obterNotas);

                // Linha separadora
                Funcoes.LinhaSeparadora();

                // Exibe a média
                Console.WriteLine($"A média do aluno é: {media:F2}");

                // Linha separadora
                Funcoes.LinhaSeparadora();

                // Pergunta se deseja continuar
                do
                {
                    Console.Write("Deseja Calcular a Média Novamente? [ S / N] ");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar != "S" && continuar != "N")
                    {
                        Console.WriteLine("Escolha inválida! Digite Apenas 'S' ou 'N'.");
                    }
                }
                while (continuar != "S" && continuar != "N");

            } while (continuar == "S");
        }
    }
}