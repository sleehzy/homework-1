using System;
using System.Collections.Generic;
using System.Text;

namespace homework_1
{
    public class Compressor
    {
       

        public void CompressArray()
        {
            
            int[] sourceArray = { 0, 5, 0, 3, 0, 1, 0, 9 };

            Console.WriteLine("Исходный массив: " + string.Join(", ", sourceArray));

            
            int[] nonZeroElements = sourceArray.Where(element => element != 0).ToArray();

            
            int[] resultArray = new int[sourceArray.Length];

           
            Array.Copy(nonZeroElements, resultArray, nonZeroElements.Length);

           
            for (int i = nonZeroElements.Length; i < resultArray.Length; i++)
            {
                resultArray[i] = -1;
            }

            Console.WriteLine("Результат:       " + string.Join(", ", resultArray));
        }
    }
}