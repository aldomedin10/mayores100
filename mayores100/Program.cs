using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayores100
{
    class Program
    {
        private int[] vec;

        public void cargar()
        {
            Console.Write("cantidad de elementos:");
            int n = int.Parse(Console.ReadLine());
            vec = new int[n];
            for (int f = 0; f < vec.Length; f++)
            {
                Console.Write("ingrese el valor de la componente:");
                string linea;
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }

        }

        public void imprimir()
        {
            int cant = 0;
            foreach (var valor in vec)
            {
                if(valor > 100)
                {
                    cant++;
                }

            }
            Console.Write("la cantidad de elementos mayores a 100 son:" + cant);
            Console.ReadKey();

        }
        static void Main(string []arg)
        {
            mayores100 m = new mayores100();
            m.caragar();
            m.imprimir();
        }

       
        
       
    }
}
