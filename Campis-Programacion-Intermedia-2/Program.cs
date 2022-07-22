using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Campis_Programacion_Intermedia_2
{
    internal partial class Program
    {
        class Clase
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Pass { get; set; }

            public Clase(int id, string nombre, string pass)
            {
                Id = id;
                Nombre = nombre;
                Pass = pass;
            }
        }
        struct Struct
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Pass { get; set; }

            public Struct(int id, string nombre, string pass)
            {
                Id = id;
                Nombre = nombre;
                Pass = pass;
            }
        }
        static void ReverseWithQueue(int[] arreglo)
        {
            var timer = new Stopwatch();

            timer.Start();
            Queue<int> cola = new Queue<int>();

            foreach(var item in arreglo)
            {
                cola.Enqueue(item);
            }
            var arreglo2 = cola.Reverse().ToArray();
            foreach (var item in arreglo2)
            {
                Console.WriteLine(item);
            }
            timer.Stop();

            TimeSpan elapsedTime = timer.Elapsed;
            Console.WriteLine("Tiempo de ejecucion: " + elapsedTime.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Primer elemento: " + arreglo2[0]);
        }

        static void ReverseWithDict(int[] arreglo)
        {
            var timer = new Stopwatch();

            timer.Start();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < arreglo.Length; i++)
            {
                dict.Add(i, arreglo[i]);
            }
            var reversedDictionary = dict.Reverse();

            var arreglo2 = reversedDictionary.Select(z => z.Value).ToArray();

            foreach(var item in arreglo2)
            {
                Console.WriteLine(item);
            }

            timer.Stop();

            TimeSpan elapsedTime = timer.Elapsed;
            Console.WriteLine("Tiempo de ejecucion: " + elapsedTime.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Primer elemento: " + arreglo2[0]);

        }

        static void ReverseWithLis(int[] arreglo)
        {
            var timer = new Stopwatch();

            timer.Start();

            List<int> lista = new List<int>();
            foreach(var item in arreglo)
            {
                lista.Add(item);
            }
            List<int> listaInversa = Enumerable.Reverse(lista).ToList();
            listaInversa.ForEach((item) => Console.WriteLine(item));

            timer.Stop();

            TimeSpan elapsedTime = timer.Elapsed;
            Console.WriteLine("Tiempo de ejecucion: " + elapsedTime.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Primer elemento: " + listaInversa[0]);
        }

        static bool Palindromo(string texto)
        {
            Stack<string> Pila = new Stack<string>();

            foreach (char c in texto)
            {
                Pila.Push(c.ToString());
            }
            string? texto2 = null;
            while (Pila.Count > 0)
            {
                texto2 += Pila.Peek(); Pila.Pop();
            }

            if (texto.ToLower().Equals(texto2.ToLower())) return true;
            return false;
            
        }

        static void Main(string[] args)
        {
            // Tuplas
            Console.WriteLine("Tuplas: \n\n");
            List<(int, int)> tupla1 = new();
            tupla1.Add((1,2));
            tupla1.Add((2, 3));
            tupla1.Add((4, 5));
            tupla1.Add((6, 7));

            List<(string Name, string Kind, int Replica, bool Run)> tupla2 = new();

            tupla2.Add(("Blabla", "Bleble", 10, true));
            tupla2.Add(("Nirvana", "Come As You Are", 11, false));
            tupla2.Add(("Nirvana", "Heart Shaped Box", 12, false));
            tupla2.Add(("Metallica", "Unforgiven", 13, true));

            Console.WriteLine("Impresion Tupla 1: \n");
            tupla1.ForEach((t1) => Console.WriteLine(t1));

            Console.WriteLine();

            Console.WriteLine("Impresion Tupla 2: \n");
            tupla2.ForEach((t2) => Console.WriteLine(t2));

            Console.WriteLine();

            // Tipos Por Valor Y Referencia
            var timerClase = new Stopwatch();
            var timerStruct = new Stopwatch();

            Clase[] clases = new Clase[1000000];
            timerClase.Start();
            for (int i = 0; i < clases.Length; i++)
            {
                clases[i] = new Clase(i, "nombre", "pass");
            }
            timerClase.Stop();

            TimeSpan tiempoEjecucionClase = timerClase.Elapsed;
            Console.WriteLine("Tiempo Ejecuion Clase: " + tiempoEjecucionClase.ToString(@"m\:ss\.fff"));

            Console.WriteLine();

            Struct[] structs = new Struct[1000000];
            timerStruct.Start();
            for(int i = 0; i < structs.Length; i++)
            {
                structs[i] = new Struct(i, "nombre", "pass");
            }
            timerStruct.Stop();

            TimeSpan tiempoEjecucionStruct = timerStruct.Elapsed;
            Console.WriteLine("Tiempo Ejecucion Struct: " + tiempoEjecucionStruct.ToString(@"m\:ss\.fff"));

            // Colas, Listas, Diccionarios
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            int[] arreglo = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Arreglo origianl: ");
            foreach(var item in arreglo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Arreglo inverso con Cola: ");
            ReverseWithQueue(arreglo);
            Console.WriteLine();
            Console.WriteLine("Arreglo inverso con Lista: ");
            ReverseWithLis(arreglo);
            Console.WriteLine();
            Console.WriteLine("Arreglo inverso con Diccionario: ");
            ReverseWithDict(arreglo);
            Console.WriteLine();

            // Es Palindromo?
            string nombre = "Anna";
            Console.WriteLine(Palindromo(nombre));

            nombre = "Zeppelin";
            Console.WriteLine(Palindromo(nombre));

        }
    }
}
