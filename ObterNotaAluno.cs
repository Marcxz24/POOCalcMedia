using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCalcMedia
{
    public class ObterNotaAluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public void ObterNotas() 
        {
            double nota = 0;

            bool nota1Valida = false, nota2Valida = false, nota3Valida = false, nota4Valida = false;

            while (!nota1Valida)
            {
                Console.Write("Digite a primeira nota: ");
                string StrNota1 = Console.ReadLine();

                if (double.TryParse(StrNota1, out nota))
                {
                    // Validação da nota entre 0 e 25
                    if (nota < 0 || nota > 25)
                    {
                        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 25.");
                        continue;
                    }

                    Nota1 = nota;
                    nota1Valida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a nota.");
                    continue;
                }
            }

            while (!nota2Valida)
            {
                Console.Write("Digite a segunda nota: ");
                string StrNota2 = Console.ReadLine();
                if (double.TryParse(StrNota2, out nota))
                {
                    // Validação da nota entre 0 e 25
                    if (nota < 0 || nota > 25)
                    {
                        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 25.");
                        continue;
                    }

                    Nota2 = nota;
                    nota2Valida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a nota.");
                    continue;
                }
            }

            while (!nota3Valida)
            {
                Console.Write("Digite a terceira nota: ");
                string StrNota3 = Console.ReadLine();
                if (double.TryParse(StrNota3, out nota))
                {
                    // Validação da nota entre 0 e 25
                    if (nota < 0 || nota > 25)
                    {
                        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 25.");
                        continue;
                    }

                    Nota3 = nota;
                    nota3Valida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a nota.");
                    continue;
                }
            }

            while (!nota4Valida)
            {
                Console.Write("Digite a quarta nota: ");
                string StrNota4 = Console.ReadLine();
                if (double.TryParse(StrNota4, out nota))
                {
                    // Validação da nota entre 0 e 25
                    if (nota < 0 || nota > 25)
                    {
                        Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 25.");
                        continue;
                    }

                    Nota4 = nota;
                    nota4Valida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido para a nota.");
                    continue;
                }
            }
        }
    }
}
