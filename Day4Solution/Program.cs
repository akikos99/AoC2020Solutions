using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//Lost on this problem

namespace Day4Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay4Input.txt"));

            Console.WriteLine($"Part one solution: {PartOne(input)}\n");
            //Console.WriteLine($"Part two solution: {PartTwo(input)}\n");
        }


        public static int PartOne(string[] input) 
        {
            //Need to split by \n for each separate person
            //so maybe 
            foreach (string line in input)
            {
                do 
                {
                    int hat = 1;
                } while (line != null);
            }
            
        }

        // public static int PartTwo(string[] input) 
        // {
            
        // }
        
    }
}
