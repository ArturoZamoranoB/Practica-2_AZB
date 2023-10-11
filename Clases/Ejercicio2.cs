using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_AZB.Clases
{
    internal class Ejercicio2
    {
        public void Practica_2()
        {

            int[] array1 = new int[10] {1,2,1,4,5,1,7,8,1,10};
            
            int[] Posiciones = new int[array1.Length];

            Console.WriteLine("ingrese el elemento a buscar");
            int elemento = Convert.ToInt32(Console.ReadLine());
            int cont = 0;

            for (int i = 0; i < array1.Length;i++)
            {
                if (array1[i] == elemento)
                {
                    Posiciones[cont] = i;
                    cont++;                
                }
            }
            Console.WriteLine($"Existen {cont} coincidencia en las posiciones siguientes:");
            Console.WriteLine("---------------------------------------------------------");
            for (int i =0; i<cont;i++)
            {
                Console.WriteLine($"Posicion donde se encuentra la concidencia = {Posiciones[i]}" + "");
                Console.WriteLine("-----------------");
            }
        }
            
       



    }
}
