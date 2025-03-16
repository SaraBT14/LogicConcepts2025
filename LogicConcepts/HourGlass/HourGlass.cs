using System;

class Hourglass
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz (impar): ");
        int N = int.Parse(Console.ReadLine());
        if (N % 2 == 0)
        {
            Console.WriteLine("El número debe ser impar.");
            return;
        }

        int[,] matriz = new int[N, N];

        // Llenar la matriz con el patrón dado
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = (i + j) * 2;
            }
        }

        // Mostrar la matriz completa
        Console.WriteLine("MATRIZ COMPLETA");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Mostrar la figura del reloj de arena
        Console.WriteLine("\nRELOJ DE ARENA");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (j >= i && j < N - i || j <= i && j >= N - i - 1)
                    Console.Write(matriz[i, j] + "\t");
                else
                    Console.Write(" \t");
            }
            Console.WriteLine();
        }
    }
}
