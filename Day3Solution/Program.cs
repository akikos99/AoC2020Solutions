using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


//UNFINISHED

namespace Day3Solution
{
    class Program3
    {
        static void Main(string[] args)
        {
            //var input = (File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay3Input.txt"))).ToList();
            //var input = inputS.ToList();
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay3Input.txt"));
            Console.WriteLine($"Part one solution: {PartOne(input)}\n");
            //Console.WriteLine($"Part two solution: {PartTwo(input)}\n");
        }


        private static int PartOne(string[] input) 
        {
            int trees = 0;

            // foreach (string line in input)
            // {
                int lineLength = input[0].Length;
                int row = 0;
                int column = 0;
                //System.Console.WriteLine(lineLength);

                while (row != input.Length - 1)
                {
                    row++;
                    
                    column += 3;

                    if (column >= lineLength)
                    {
                        column = column % lineLength;
                    }

                    if (input[row].Substring(column, 1)  == "#")
                    {
                        trees++;
                    }
            }

            return trees;
        }

                // }
                //for (row = 0; row < 11; row++) //No longer needed because I just need to extend to the right
                // {
                //     if (line.Substring(column, 1) == "#")
                //     {
                //         column = column + 3;
                //         tree++;
                //     }
                // }
                
           // }
           //return trees;

        
    }
}
