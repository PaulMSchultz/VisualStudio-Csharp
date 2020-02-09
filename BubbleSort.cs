using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Bubble Sort Demo"); // INTRO
            Console.WriteLine("Enter numbers in any order and Bubble Sort will order them in ascending value!"); // Explanation

            int userInput = 0; // variable creation
            List<int> numList = new List<int>(); // list creation

            while (userInput != -1) //allowing for multiple numbers to be entered
            {
                try // exception for not entering an int
                {
                    Console.WriteLine("Enter a number, -1 when done");
                    userInput = Int32.Parse(Console.ReadLine()); // converting string inputs to int

                    if (userInput == -1) // once user is finished inputting data
                    {
                        break;
                    }
                    numList.Add(userInput); // adding user int inputs into list
                }
                catch (Exception) // error message then return back up the while loop
                {
                    Console.WriteLine("Error. Enter a valid number...");
                }
            }            

            bubbleSort(numList); // calling method using list    

            foreach (int i in numList) // foreach loop to print out final sorted values
            {
                Console.Write($"{i} ");
            }

            Environment.Exit(-1); // press enter to exit cmd
        }

        static void bubbleSort(List<int> numList) //Bubble Sort Method
        {
            for (int i = 0; i < numList.Count - 1; i++) // for loop to search through list
            {
                for (int num = 0; num < numList.Count - 1; num++) // nested for loop to compare first number with the rest of the list
                {
                    while (numList[num] > numList[num + 1]) // nested while loop to compare int value that are next to each other, is list<0> > list<1> ?
                    {
                        int temp = numList[num]; // temp storage as to not lose the value when swapping
                        numList[num] = numList[num + 1]; // swap higher number over to the right
                        numList[num + 1] = temp; // swap that lower value to the left
                    }
                }
            }
        }
    }
}
