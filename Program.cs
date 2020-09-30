// Author: Franchesca Guerra
// Date: 9/29/20
// Arrays console application 


using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                
                
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("First let's automatically populate anarray with intergers");
                    Console.WriteLine("Then let's iterate through the elements in the array with a for loop");

                    
                    const int SIZE = 25;
                    int[] myValues = new int[SIZE];

                    Console.WriteLine( SIZE + " Elements should be populated in the array.");

                    int pop_array = 0; 

                    for (int index = 0; index < SIZE; index++)
                    {
                        myValues[index] = pop_array;
                        Console.Write(index + " ");

                    } 
                    Console.WriteLine("");
                    Console.WriteLine("______________________");
                    Console.WriteLine("Press any key to exit the program...");
                    
                    

                }
            }
            catch
            {
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}


