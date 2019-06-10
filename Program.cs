using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bel2
{
    class Program
    {
        static void Main(string[] args)
        {
            int materias;
            float nt;
            Console.Write("Quantas matérias você tem? ");
            materias = int.Parse(Console.ReadLine());
            int[,] mtz = new int[materias, 4];

            for (int x = 0; x < materias; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write("Informe  sua nota na materia " + (x + 1) + " unidade " + (y + 1) + ": ");
                    nt = float.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
