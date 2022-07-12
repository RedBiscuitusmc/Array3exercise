using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var AS50 = 51;
            var terms = new int[AS50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater_Array(terms, AS50);
            //TODO: Print the first number of the array
            Console.WriteLine($"Printing the first number in the array {terms[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"Printing the last number in the array {terms[50]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            Populater_Array(terms, AS50);
            Console.WriteLine("-------------------");
            //TODO: Reverse the contents of the array and then print the array out to the console.
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(terms);
            NumberPrinter(terms, AS50);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(terms, AS50);
            Console.WriteLine("-------------------");
            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(terms, AS50);
            NumberPrinter(terms, AS50);
            Console.WriteLine("-------------------");
            //TODO: Sort the array in order now
            Console.WriteLine("Sorted numbers:");
            Array.Sort(terms);
            NumberPrinter(terms, AS50);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");
            /*   Set Up   */
            //TODO: Create an integer List
            var myList = new List<int>();
            //TODO: Print the capacity of the list to the console
            Console.WriteLine(myList.Capacity);
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);
            NumberPrinter_1(myList);
            //TODO: Print the new capacity
            Console.WriteLine(myList.Capacity);
            Console.WriteLine("---------------------");
            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int Input;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Input))
                {
                    break;
                }
                Console.WriteLine("You didn't enter a number, try again");
            }
            NumberChecker(myList, Input);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter_1(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            NumberPrinter_1(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter_1(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArray = myList.ToArray();
            Console.WriteLine(newArray.Length);
            //TODO: Clear the list
            myList.Clear();
            Cleared();
            #endregion
        }
        private static void Cleared()
        {
            Console.WriteLine("List cleared");
        }
        private static void NumberPrinter_1(List<int> myList)
        {
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
        }
        private static void NumberPrinter(int[] terms, int AS50)
        {
            foreach (int i in terms)
            {
                Console.WriteLine(i);
            }
        }

        private static void ThreeKiller(int[] terms, int AS50)
        {
            for (int i = 0; i < terms.Length; i++)
            {
                if (i % 3 == 0)
                {
                    terms[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> myList)
        {
            for (int i = myList.Count -1;  i >= 0; i--)
            {
                if (myList[i] % 2 != 0)
                {
                    myList.RemoveAt(i);
                }
            }
        }

        private static void NumberChecker(List<int> myList, int Numbs)
        {
            var answer = myList.Contains(Numbs) ? "Number was found!" : "Number was not found";
            Console.WriteLine(answer);
        }

        private static void Populater(List<int> myList)
        {
            Random Rng = new Random();
            while (myList.Count <= 50)
            {
             myList.Add(Rng.Next(0, 50));
            }

        }

        private static void Populater_Array(int[] terms, int AS50)
        {
            Random rng = new Random();
            int Num = 0;
            foreach (int eachInNumbers in terms)
            {
                terms[Num] = rng.Next(0, 50);
                    Num++;
            }
        }

        private static void ReverseArray(int[] terms, int AS50)
        {
            Array.Reverse(terms);
            foreach (int i in terms)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}