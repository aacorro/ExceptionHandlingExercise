using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = new char[9] { '9', '8', '7', '6', '5', '4', 'x', 'y', 'z'};


            // Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();


            // Create an string variable with an empty string initializer - name it str
            string str = "";


            // Using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // An Exceptions will be thrown 
            foreach (char c in arr)
            {
                // Now create a try catch
                try
                {
                    // set your string variable to each array element in your char[] to .ToString()
                    str = c.ToString();
                    
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    int i = int.Parse(str);
                    
                    // Then add each int to your list
                    numbers.Add(i);

                }
                catch (Exception ex)
                {
                    //character will be the name of each item in your collection
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }
            
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


        }
    }
}
