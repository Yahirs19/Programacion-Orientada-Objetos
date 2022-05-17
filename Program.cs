using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaExcepcionIndexOutOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            void Limpiar()
            {
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            // Variables Auxiliares
            int[] arreglo = new int[10];
            Random R = new Random();
            try
            {
                //Generacion aleatoria del vector
                for (int x = 0; x < arreglo.Length; x++)
                {
                    arreglo[x] = R.Next(10, 99);
                }
                // Ordenamiento del vector
                Array.Sort(arreglo);

                // Despliegue del vector ordenado
                Console.WriteLine("" +
                    "Arreglo Ordenado");
                for (int x = 0; x < arreglo.Length; x++)
                {
                    Console.WriteLine("\t{0}.-{1} ", x + 1, arreglo[x]);
                }
                Limpiar();
                //arreglo[15] = 12345; //Acceso indice fuera de rango
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine("Mensaje del Error: " + i.Message);
                Console.WriteLine("\nRuta del Error: " + i.StackTrace);
                Limpiar();
            }
            finally
            {
                Console.WriteLine("El bloque finally siempre se ejecuta");
                Limpiar();
            }
        }
    }
}
