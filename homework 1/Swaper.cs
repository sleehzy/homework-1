using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    public class MatrixColumnSwapper
    {
        public void SwapColumns()
        {
            int[,] matrix = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            
            Console.Write("Введите индекс первого столбца для замены: ");
            int firstColumnIndex = int.Parse(Console.ReadLine());

            Console.Write("Введите индекс второго столбца для замены: ");
            int secondColumnIndex = int.Parse(Console.ReadLine());

            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            
            if (firstColumnIndex >= 0 && firstColumnIndex < columnCount &&
                secondColumnIndex >= 0 && secondColumnIndex < columnCount)
            {
                
                for (int i = 0; i < rowCount; i++)
                {
                    int tempValue = matrix[i, firstColumnIndex];
                    matrix[i, firstColumnIndex] = matrix[i, secondColumnIndex];
                    matrix[i, secondColumnIndex] = tempValue;
                }

                Console.WriteLine($"\nМатрица после замены столбцов {firstColumnIndex} и {secondColumnIndex}:");
                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Ошибка: Введены некорректные индексы столбцов.");
            }
        }

       
        private void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}