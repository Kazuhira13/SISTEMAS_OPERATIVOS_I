using System;

class CalculadoraVersion3
{
    static void Main(string[] args)
    {
        double num1 = ObtenerNumero("Ingrese el primer número:");
        double num2 = ObtenerNumero("Ingrese el segundo número:");
        char operacion = ObtenerOperacion();

        double resultado = Calcular(num1, num2, operacion);
        Console.WriteLine($"\nEl resultado es: {resultado}");
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
}
