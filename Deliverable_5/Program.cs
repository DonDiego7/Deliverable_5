
/*
Author: Diego Fernandez
Date: 2/16/2023
Description: This program will use two methods to first randomly populate an array w/ integrers between 10 and 50
and then return the summation of all the elements in the array
*/

using System;
namespace Deliverable_5
{
    internal class Program
    {
        static int[] RA1(int ALength)
        {
            Random random = new Random();
            int[] RA2 = new int[ALength];
            for (int i = 0; i < ALength; i++)
            {
                RA2[i] = random.Next(10, 50);
            }
            return RA2;
        }

        static int sum(int[] A3)
        {
            int sum = 0;
            foreach (int i in A3)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //Ask user to enter integer
            Console.WriteLine("Enter an integer number between 5 and 15");

            try
            {

                int input = int.Parse(Console.ReadLine());

                if (input > 5 && input < 15)
                {
                    int[] RA2 = RA1(input);
                    Console.Write("The elements in the random array are: ");
                    foreach (int i in RA2)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is : " + sum(RA2));
                }
                else
                {
                    Console.WriteLine("Make sure to type an integer between 5 and 15 next time");
                }
            }
            catch
            {
                Console.WriteLine("Make sure to type an integer between 5 and 15 next time");
            }
            
        }
    }
}
