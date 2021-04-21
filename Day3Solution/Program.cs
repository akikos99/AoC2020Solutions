using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


//UNFINISHED

namespace Day3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay3Input.txt"));

            
            Console.WriteLine($"Part one solution: {PartOne(input)}\n");
            //Console.WriteLine($"Part two solution: {PartTwo(input)}\n");
        }


        public static int PartOne(string[] input) 
        {
            int row;
            int tree = 0;

            foreach (string line in input)
            {
                int column = 4;
                
                for (row = 0; row < 11; row++)
                {
                    if (line.Substring(column, 1) == "#")
                    {
                        column = column + 3;
                        tree++;
                    }
                }
                
            }
           return tree;
        }

        
    }
}
