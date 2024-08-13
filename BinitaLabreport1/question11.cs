using System;
namespace BinitaLabreport1
{
    internal class question11
    {
        /*static void Main()
        {
            var matrixA = InputMatrix("first");

            var matrixB = InputMatrix("second");

            if (!CanMultiply(matrixA, matrixB))
            {
                Console.WriteLine("Matrix multiplication is not possible. Number of columns of the first matrix must be equal to number of rows of the second matrix.");
                return;
            }
            var resultMatrix = MultiplyMatrices(matrixA, matrixB);
            DisplayMatrix(resultMatrix, "Resulting Matrix");
        }

        static int[][] InputMatrix(string matrixName)
        {
            Console.WriteLine($"Enter the number of rows for the {matrixName} matrix:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the number of columns for the {matrixName} matrix:");
            int cols = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];
            Console.WriteLine($"Enter the elements of the {matrixName} matrix row by row:");
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            return matrix;
        }

        static bool CanMultiply(int[][] matrixA, int[][] matrixB)
        {
            return matrixA[0].Length == matrixB.Length;
        }

        static int[][] MultiplyMatrices(int[][] matrixA, int[][] matrixB)
        {
            int rowsA = matrixA.Length;
            int colsB = matrixB[0].Length;
            int colsA = matrixA[0].Length;

            int[][] resultMatrix = new int[rowsA][];
            for (int i = 0; i < rowsA; i++)
            {
                resultMatrix[i] = new int[colsB];
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i][j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i][j] += matrixA[i][k] * matrixB[k][j];
                    }
                }
            }

            return resultMatrix;
        }

        static void DisplayMatrix(int[][] matrix, string matrixName)
        {
            Console.WriteLine(matrixName + ":");
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        

        Console.ReadKey();
                Console.Read();
            }
*/
}

    }




