//Santiago Robles Abarca 331-32 22/10/2026
using System;
namespace CS1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Sintaxis para definir una funcion
            //definir parametros
            void Saludar()
            {
                Console.WriteLine("Hola");
            }
            //invocacion
            Saludar();


            //2 Imprimir la secuencia: 2,4,6,9,2,12,15,19,23,27
            int n = 2;
            while (n <= 6)
            {
                Console.WriteLine(n);
                n += 2;
            }
            n = 9;
            while (n <= 15)
            {
                Console.WriteLine(n);
                n += 3;
            }
            n = 19;
            while (n <= 27)
            {
                Console.WriteLine(n);
                n += 4;
            }


            //3 Ciclo ascendente o descendente
            int inicio = 9;
            int limite = 1;
            if (inicio * limite < 8 && inicio > limite)
            {
                for (int i = inicio; i > limite; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = inicio; i <= limite; i++)
                {
                    Console.WriteLine(i);
                }
            }


            //4 Funcion para determinar si un numero es multiplo de 5
            bool MultiploDe5(int numero)
            {
                if (numero % 5 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            bool devolucion;
            devolucion = MultiploDe5(15);
            Console.WriteLine($"Devolucion: {devolucion}");


            // 5. Funcion vacia con un argumento
            void ImprimirExamen(string materia)
            {
                Console.WriteLine($"examen {materia}");
            }
            ImprimirExamen("programacion III");
        }
    }
}