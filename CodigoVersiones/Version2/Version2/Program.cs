using System;

class CalculadoraVersion2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Elija una operación (+, -, *, /):");
        char operacion = Console.ReadKey().KeyChar;

        double resultado = 0;

        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("\nNo se puede dividir por cero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                return;
        }

        Console.WriteLine($"\nEl resultado es: {resultado}");
    }
}
