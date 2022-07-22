using System;
using System.Collections.Generic;
using System.Diagnostics;

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
                Id =id;
                Nombre =nombre;
                Pass = pass;
            }
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


        }
    }
}
