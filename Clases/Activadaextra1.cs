using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_AZB.Clases
{
    internal class Activadaextra1
    {
        public void arreglosbidimensionales()
        {
            int[] a = new int[15] {5,10,15,20,25,30,35,40,45,50,55,60,65,70,75 };
            int[] b = new int[20];

            for (int i=5; i < a.Length; i++)
            {
                b[i + 5] = a[i];
            }

            Console.WriteLine($"Los valores de a son  {string.Join(",",a) }");
            Console.WriteLine($"Los valores de a son  {string.Join(",", b)}");
        }
    }
}
