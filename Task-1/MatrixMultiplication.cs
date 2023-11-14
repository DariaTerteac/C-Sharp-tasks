using System;

namespace MatrixMultiplication
{
  class MatrixMultiplication
  {
    static void Main(string[] args)
    {
      int numberOfRows = 2;
      int numberOfColumns = 2;
      int[,] matrixA = { { 1, 2 }, { 3, 4 } };
      int[,] matrixB = { { 5, 6 }, { 7, 8 } };
      int[,] matrixC = new int[numberOfRows, numberOfColumns];

      // Method to display matrix
      static void DisplayMatrix(string label, int[,] matrix)
      {
        Console.WriteLine(label);
        foreach (int row in new[] { 0, 1 })
        {
          foreach (int col in new[] { 0, 1 })
            Console.Write(matrix[row, col] + " ");
          Console.WriteLine();
        }
      }

      // Matrix multiplication
      for (int i = 0; i < numberOfRows; i++)
      {
        for (int j = 0; j < numberOfColumns; j++)
        {
          matrixC[i, j] = 0;
          foreach (int k in new[] { 0, 1 })
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
        }
      }

      // Display matrices
      DisplayMatrix("Matrix A:", matrixA);
      DisplayMatrix("Matrix B:", matrixB);
      DisplayMatrix("Matrix C:", matrixC);

    }
  }
}
