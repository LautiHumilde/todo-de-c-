using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expresion = "5 3 4 * + 7 -";
        int resultado = EvaluarExpresion(expresion);
        Console.WriteLine("Resultado: " + resultado);
    }

    static int EvaluarExpresion(string expresion)
    {
        string[] tokens = expresion.Split(' ');

        Stack<int> pila = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int numero))
            {
                pila.Push(numero);
            }
            else
            {
                RealizarOperacion(pila, token);
            }
        }

        return pila.Pop();
    }

    static void RealizarOperacion(Stack<int> pila, string operador)
    {
        int operand2 = pila.Pop();
        int operand1 = pila.Pop();

        switch (operador)
        {
            case "+":
                pila.Push(operand1 + operand2);
                break;
            case "-":
                pila.Push(operand1 - operand2);
                break;
            case "*":
                pila.Push(operand1 * operand2);
                break;
            case "/":
                pila.Push(operand1 / operand2);
                break;
            default:
                throw new ArgumentException("Token no reconocido: " + operador);
        }
    }
}
