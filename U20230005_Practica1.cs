using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables        
            string? nombre;
            int edad;
            string? direccion;
            int telefono; 
            string? universidad;
            string? carrera;
            string? facultad; 
            int ciclo;

            Console.WriteLine("\n**********Practica 1 - Programacion estructurada**********\n");
            Console.WriteLine("\n");
            Console.WriteLine("Ingresar nombre completo:");//Obteniendo datos
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar su edad:"); //Obteniendo datos
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar su direccion:"); //Obteniendo datos
            direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar su numero telefonico:"); //Obteniendo datos
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar la universidad:"); //Obteniendo datos
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar la carrera:"); //Obteniendo datos
            carrera = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar la facultad:"); //Obteniendo datos
            facultad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Ingresar el ciclo de estudio"); //Obteniendo datos
            ciclo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            //Obteniendo datos

            Console.WriteLine("Su nombre es: " + nombre );
            Console.WriteLine("Su edad es: " + edad );
            Console.WriteLine("Su direccion es: " + direccion );
            Console.WriteLine("Su telefono es: " + telefono );
            Console.WriteLine("Estudia en la universidad: " + universidad );
            Console.WriteLine("Su carrera es: " + carrera );
            Console.WriteLine("Facultadad a la que pertenece: " + facultad );
            Console.WriteLine("Su ciclo cursando es: " + ciclo );
        }
    }
}