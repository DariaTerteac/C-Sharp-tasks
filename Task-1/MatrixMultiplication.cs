using System;

namespace MatrixMultiplication
{
  class MatrixMultiplication
  {
    static void Main(string[] args)
    {
      int i, j, k;
      int numberOfRows = 2;
      int numberOfColumns = 2;
      int[,] matrixA = { { 1, 2 }, { 3, 4 } };
      int[,] matrixB = { { 5, 6 }, { 7, 8 } };
      int[,] matrixC = new int[numberOfRows, numberOfColumns];

      // Matrix multiplication
      for (i = 0; i < numberOfRows; i++)
      {
        for (j = 0; j < numberOfColumns; j++)
        {
          matrixC[i, j] = 0;
          for (k = 0; k < 2; k++)
          {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
          }
        }
      }

      // Display Matrix A
      Console.WriteLine("Matrix A:");
      for (i = 0; i < numberOfRows; i++)
      {
        for (j = 0; j < numberOfColumns; j++)
        {
          Console.Write(matrixA[i, j] + " ");
        }
        Console.WriteLine();
      }

      // Display Matrix B
      Console.WriteLine("Matrix B:");
      for (i = 0; i < numberOfRows; i++)
      {
        for (j = 0; j < numberOfColumns; j++)
        {
          Console.Write(matrixB[i, j] + " ");
        }
        Console.WriteLine();
      }

      // Display Matrix C
      Console.WriteLine("Matrix C:");
      for (i = 0; i < numberOfRows; i++)
      {
        for (j = 0; j < numberOfColumns; j++)
        {
          Console.Write(matrixC[i, j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
