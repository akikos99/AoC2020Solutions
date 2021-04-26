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
                int lineLength = line.Length();
                int column = 1;
                
                do
                {
                    if (line.Substring(column, 1) == "#")
                    {
                        column = column + 3;
                        tree++;
                    }

                    if (column > lineLength)
                    {
                        column = column % lineLength;
                    }
                }
                while (line != null);
                //for (row = 0; row < 11; row++) //No longer needed because I just need to extend to the right
                // {
                //     if (line.Substring(column, 1) == "#")
                //     {
                //         column = column + 3;
                //         tree++;
                //     }
                // }
                
            }
           return tree;
        }

        
    }
}
