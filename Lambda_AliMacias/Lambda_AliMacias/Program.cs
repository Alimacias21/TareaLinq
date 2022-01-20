using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_AliMacias
{
    class Program
    {
        static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
            };

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Dado la siguiente coleccion de datos, utilizando expresiones Lambda:");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Muestre por pantalla los nombres de los estudiantes");
            Console.WriteLine("Nombres:");
            details.ForEach(x => Console.WriteLine(x.Nombre));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor");
            var promedio = details.OrderByDescending(x => x.Promedio).ToList();
            Console.WriteLine("Nombre Apellido \tPromedio");
            promedio.ForEach(x => Console.WriteLine(x.Nombre + " " + x.Apellido + "\t\t" + x.Promedio));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente");
            var apellidos = details.OrderBy(x => x.Apellido).ToList();
            Console.WriteLine("Apellidos en orden alfabético");
            apellidos.ForEach(x => Console.WriteLine(x.Apellido));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("4. Muestre por pantalla los datos del estudiante mas joven");
            var estudianteMasJoven = (from x in details where x.Edad == (from a in details select a.Edad).Min() select x).ToList();
            estudianteMasJoven.ForEach(x => Console.WriteLine("Id: "+x.Id + "\nNombre: " + x.Nombre + "\nApellido: " + x.Apellido + 
                "\nPromedio: " + x.Promedio + "\nEdad: " + x.Edad));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");




            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Dado la siguiente coleccion de datos, utilizando expresiones Lambda:");
            list.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Muestre por pantalla el cuadrado de los números");
            var cuadrado = list.Select(x => x * x).ToList();
            cuadrado.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("2. Muestre por pantalla los números pares");
            var par = list.FindAll(x => x % 2 == 0);
            par.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares");
            var impar = (from n in list where (n % 2 != 0) select n * 5).ToList();
            impar.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
