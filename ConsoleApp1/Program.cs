using System;

class Calculadora //DEFINIR NOME DA CLASSE
{
    static void Main()
    {
        double num1, num2; //DEFINIR O TIPO INTEIRO OU DOUBLE
        string operador;

        Console.WriteLine("Calculadora Simples\n");

        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        operador = Console.ReadLine();

        double resultado = 0;

        switch (operador)
        {
            case "+":
                resultado = num1 + num2;
                break;

            case "-":
                resultado = num1 - num2;
                break;

            case "*":
                resultado = num1 * num2;
                break;

            case "/":
                resultado = num1 / num2;
                break;

            default:
                Console.WriteLine("Operador inválido.");
                break;
        }

        Console.WriteLine("Resultado: " + resultado);

        Console.WriteLine("\nPressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
