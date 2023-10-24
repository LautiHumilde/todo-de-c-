using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        reverse(array);

        string parentesis = "())(";

        if (balanceado(parentesis))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    static void reverse(int[] arr)
    {
        for(int i = arr.Length-1 ; i >= 0; i-- ){
            Console.WriteLine(arr[i]);
        }
    }

    static bool balanceado(string parentesis)
    {
        int contador = 0;

        foreach (char simbolo in parentesis)
        {
            if (simbolo == '(')
            {
                contador++;
            }
            else if (simbolo == ')')
            {
                contador--;

                if (contador < 0)
                {
                    return false;
                }
            }
        }

        return contador == 0;
    }

}
