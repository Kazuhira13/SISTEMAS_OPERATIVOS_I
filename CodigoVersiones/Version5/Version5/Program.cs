using System;
using System.Collections.Generic;

class CalculadoraVersion5
{
    static List<string> historial = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            MostrarHistorial();

            try
            {
                double num1 = ObtenerNumero("Ingrese el primer número:");
                double num2 = ObtenerNumero("Ingrese el segundo número:");
                char operacion = ObtenerOperacion();

                double resultado = Calcular(num1, num2, operacion);
                if (!double.IsNaN(resultado))
                {
                    string operacionCompleta = $"{num1} {operacion} {num2} = {resultado}";
                    historial.Add(operacionCompleta);
                    Console.WriteLine($"\nEl resultado es: {resultado}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEntrada no válida. Asegúrese de ingresar un número.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nHa ocurrido un error: {ex.Message}");
            }

            Console.WriteLine("\n¿Desea realizar otra operación? (s/n):");
            if (Console.ReadKey().KeyChar != 's')
            {
                break;
            }
        }
    }

    static double ObtenerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }

    static char ObtenerOperacion()
    {
        Console.WriteLine("Elija una operación (+, -, *, /):");
        return Console.ReadKey().KeyChar;
    }

    static double Calcular(double num1, double num2, char operacion)
    {
        switch (operacion)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("\nNo se puede dividir por cero.");
                    return double.NaN;
                }
            default:
                Console.WriteLine("Operación no válida.");
                return double.NaN;
        }
    }

    static void MostrarHistorial()
    {
        if (historial.Count > 0)
        {
            Console.WriteLine("Historial de Operaciones:");
            foreach (string operacion in historial)
            {
                Console.WriteLine(operacion);
            }
            Console.WriteLine();
        }
    }
}
