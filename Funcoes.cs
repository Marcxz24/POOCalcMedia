using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCalcMedia
{
    internal class Funcoes
    {
        // Função de Apresentação do Programa
        public static void Apresentacao()
        {
            Console.Clear();
            LinhaSeparadora();
            Console.WriteLine("Calculadora de Médias Escolares");
            LinhaSeparadora();
        }

        // Função de Linha separadora
        public static void LinhaSeparadora()
        {
            Console.WriteLine(new string('-', 60));
        }
    }
}
