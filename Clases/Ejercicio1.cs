using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_AZB.Clases
{
    internal class Ejercicio1
    {
        public void Practica1()
        {
            Console.WriteLine("escribe un tamaño para los arrays");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[tamaño];
            int[] array2 = new int[tamaño];
            int[] Suma = new int[tamaño];
            for (int i = 0; i < tamaño; i++) {
                Console.WriteLine("Escribe un valor para el array1");
                 array1[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escribe un valor para el array2");
                array2[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"La suma de los array es {Suma[i] = array1[i] + array2[i]} en la posicion {i} ");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($" arreglo1      {array1[i]}   Posicion = {i}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($" arreglo2      {array2[i]}   Posicion = {i}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i < Suma.Length; i++)
            {
                Console.WriteLine($" arreglo1      {Suma[i]}   Posicion = {i}");
            }
        }
    }
}
