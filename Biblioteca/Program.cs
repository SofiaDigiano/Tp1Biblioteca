using System;

namespace Colecciones
{
    internal class test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Carga de datos
            biblioteca.AltaLector("Juan Perez", "12345678");
            biblioteca.AgregarLibro("Libro 1", "Autor 1", "Editorial 1");
            biblioteca.AgregarLibro("Libro 2", "Autor 2", "Editorial 2");
            biblioteca.AgregarLibro("Libro 3", "Autor 3", "Editorial 3");
            biblioteca.AgregarLibro("Libro 4", "Autor 4", "Editorial 4");

            // Caso 1: Lector Inexistente
            Console.WriteLine(biblioteca.PrestarLibro("Libro 1", "99999999")); // Retorna: LECTOR INEXISTENTE

            // Caso 2: Libro Inexistente
            Console.WriteLine(biblioteca.PrestarLibro("Libro Desconocido", "12345678")); // Retorna: LIBRO INEXISTENTE

            // Caso 3: Préstamos Exitosos (hasta 3)
            Console.WriteLine(biblioteca.PrestarLibro("Libro 1", "12345678")); // Retorna: PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.PrestarLibro("Libro 2", "12345678")); // Retorna: PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.PrestarLibro("Libro 3", "12345678")); // Retorna: PRESTAMO EXITOSO

            // Caso 4: Tope Alcanzado
            Console.WriteLine(biblioteca.PrestarLibro("Libro 4", "12345678")); // Retorna: TOPE DE PRESTAMO ALCANZADO
        }
    }
}