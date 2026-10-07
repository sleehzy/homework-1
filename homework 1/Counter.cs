using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    public class NumberCounter
    {
        public void CountOccurrences()
        {
            
            int[] numberArray = { 1, 5, 3, 5, 2, 5, 8, 1 };
            Console.WriteLine("Массив: " + string.Join(", ", numberArray));

            
            Console.Write("Введите число для поиска: ");
            string inputString = Console.ReadLine();

            if (int.TryParse(inputString, out int targetNumber))
            {
                int occurrenceCount = 0;

                
                foreach (int number in numberArray)
                {
                    if (number == targetNumber)
                    {
                        occurrenceCount++;
                    }
                }

                Console.WriteLine($"Число {targetNumber} встречается {occurrenceCount} раз(а).");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
    }
}
