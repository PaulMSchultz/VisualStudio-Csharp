using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Bubble Sort Demo");
            Console.WriteLine("Enter numbers in any order and Bubble Sort will order them in ascending value!");

            int userInput = 0;
            List<int> numList = new List<int>();

            while (userInput != -1)
            {
                try
                {
                    Console.WriteLine("Enter a number, -1 when done");
                    userInput = Int32.Parse(Console.ReadLine());

                    if (userInput == -1)
                    {
                        break;
                    }
                    numList.Add(userInput);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error. Enter a valid number...");
                }
            }            

            bubbleSort(numList);        

            foreach (int i in numList)
            {
                Console.Write($"{i} ");
            }

            Environment.Exit(-1);
        }

        static void bubbleSort(List<int> numList)
        {
            for (int i = 0; i < numList.Count - 1; i++)
            {
                for (int num = 0; num < numList.Count - 1; num++)
                {
                    while (numList[num] > numList[num + 1])
                    {
                        int temp = numList[num];
                        numList[num] = numList[num + 1];
                        numList[num + 1] = temp;
                    }
                }
            }
        }
    }
}
