using System;

public class LowerTriangularMatrix
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        int N = int.Parse(s: Console.ReadLine());
        int[,] matriz = new int[N, N];

        // Llenar la matriz con la fórmula Celda[i][j] = i + j
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = i + j;
            }
        }

        // Imprimir la matriz completa
        Console.WriteLine("Matriz completa:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Imprimir la triangular inferior
        Console.WriteLine("Triangular inferior:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


















