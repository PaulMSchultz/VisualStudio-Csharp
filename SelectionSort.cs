using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort Demo"); // INTRO
            Console.WriteLine("Enter numbers in any order and Selection Sort will order them in ascending value!"); // Explanation

            int userInput = 0; // variable creation
            List<int> numList = new List<int>(); // input list creation

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
                    numList.Add(userInput); // adding user int inputs into list, except the -1 
                }
                catch (Exception) // error message then return back up the while loop
                {
                    Console.WriteLine("Error. Enter a valid number...");
                }
            }

            //List<int> numList = new List<int> { 10, 2, 9, 3, 8, 4, 7, 5, 6 }; // premade list for testing

            selectionSort(numList); // calling method using list    

            foreach (int i in numList) // foreach loop to print out final sorted values
            {
                Console.Write($"{i} ");
            }

            Environment.Exit(-1); // press enter to exit cmd
        }

        static void selectionSort(List<int> numList) // selection sort method
        {
            for (int num = 0; num < numList.Count; num++) // for loop to move through the list until its 
            {
                int min = num; // selecting the fist number(then the 2nd, 3rd, etc..) and calling it the minimum value

                for (int i = num + 1; i < numList.Count; i++) // nested loop to check the min vs the rest of the numbers in the list
                {
                    if (numList[i] < numList[min]) // check to see if the next value is smaller
                    {
                        min = i; // if the next value is smaller, it become the new min                    
                    }
                }

                int temp = numList[num]; // temp storage as to not lose values when swapping
                numList[num] = numList[min]; // after finding the smallest number in that iteration, it swaps with the first int in the list
                numList[min] = temp; // this int swaps to the place where the min came from, using the temp storage value               
            }
        }
    }
}

