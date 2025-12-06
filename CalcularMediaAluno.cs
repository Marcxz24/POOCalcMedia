using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCalcMedia
{
    public class CalcularMediaAluno
    {
        // Método para calcular a média das notas do aluno
        public double CalcularMedia(ObterNotaAluno notas)
        {
            return (notas.Nota1 + notas.Nota2 + notas.Nota3 + notas.Nota4) / 4;
        }
    }
}
