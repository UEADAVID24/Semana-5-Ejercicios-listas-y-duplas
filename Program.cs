using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== MENÚ DE EJERCICIOS =====");
            Console.WriteLine("1. Ejercicio 4 - Lotería ordenada");
            Console.WriteLine("2. Ejercicio 5 - Números del 1 al 10 inverso");
            Console.WriteLine("3. Ejercicio 6 - Asignaturas suspendidas");
            Console.WriteLine("4. Ejercicio 7 - Eliminar letras múltiplos de 3");
            Console.WriteLine("5. Ejercicio 9 - Contar vocales");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    new Loteria().Ejecutar();
                    break;
                case "2":
                    new Inverso().Ejecutar();
                    break;
                case "3":
                    new Asignaturas().Ejecutar();
                    break;
                case "4":
                    new Abecedario().Ejecutar();
                    break;
                case "5":
                    new Vocales().Ejecutar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}

// Ejercicio 4
class Loteria
{
    public void Ejecutar()
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("Ingrese 6 números ganadores de la lotería:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }
        numeros.Sort();
        Console.WriteLine("Números ordenados: " + string.Join(", ", numeros));
    }
}

// Ejercicio 5
class Inverso
{
    public void Ejecutar()
    {
        List<int> numeros = Enumerable.Range(1, 10).ToList();
        numeros.Reverse();
        Console.WriteLine("Números en orden inverso: " + string.Join(", ", numeros));
    }
}

// Ejercicio 6
class Asignaturas
{
    private Dictionary<string, double> notas = new Dictionary<string, double>()
    {
        {"Matemáticas", 0}, {"Física", 0}, {"Química", 0}, {"Historia", 0}, {"Lengua", 0}
    };

    public void Ejecutar()
    {
        foreach (var asignatura in notas.Keys.ToList())
        {
            Console.Write($"Nota en {asignatura}: ");
            notas[asignatura] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Debes repetir:");
        foreach (var asignatura in notas)
        {
            if (asignatura.Value < 5)
                Console.WriteLine(asignatura.Key);
        }
    }
}

// Ejercicio 7
class Abecedario
{
    public void Ejecutar()
    {
        List<char> letras = new List<char>();
        for (char c = 'A'; c <= 'Z'; c++) letras.Add(c);

        for (int i = letras.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
                letras.RemoveAt(i);
        }

        Console.WriteLine("Abecedario filtrado: " + string.Join(", ", letras));
    }
}

// Ejercicio 9
class Vocales
{
    public void Ejecutar()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        Dictionary<char, int> conteo = new Dictionary<char, int>()
        {
            {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}
        };

        foreach (char c in palabra)
        {
            if (conteo.ContainsKey(c))
                conteo[c]++;
        }

        foreach (var par in conteo)
            Console.WriteLine($"Vocal {par.Key}: {par.Value} veces");
    }
}
