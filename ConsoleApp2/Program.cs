using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0, v2 = 0, v3 = 0, voto, max;
            double total, ov1, ov2, ov3;
            string ganador;

            Console.WriteLine("(1) 1° partido (2) 2° partido");
            Console.WriteLine("(3) 3° partido (4)Salir");

            do
            {
                Console.Write("Ingrese el voto:");
                voto = int.Parse(Console.ReadLine());
                if (voto == 1)
                {
                    v1 = v1 + 1;
                }
                else if (voto == 2)
                {
                    v2 = v2 + 1;
                }
                else if (voto == 3)
                {
                    v3 = v3 + 1;
                }

            } while (voto != 4);


            total = v1 + v2 + v3;
            ov1 = (v1 / total) * 10;
            ov2 = (v2 / total) * 10;
            ov3 = (v3 / total) * 10;

            Console.WriteLine("1° partido tiene : {0}", ov1);
            Console.WriteLine("2° partido tiene : {0}", ov2);
            Console.WriteLine("3° partido tiene : {0}", ov3);

            max = v1;
            ganador = "1° partido";
            if (v2 > max)
            {
                ganador = "2° partido";
            }
            if (v3 > max)
            {
                ganador = "3° partido";
            }

            Console.WriteLine("Felicidades a : {0} es el nuevo ganador de las elecciones", ganador);

            Console.ReadLine();
        }
    }
}
        
