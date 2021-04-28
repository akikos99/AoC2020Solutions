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
            //Console.WriteLine($"Part one solution: {PartOne(input)}\n");
            Console.WriteLine($"Part two solution: {PartTwo(input)}\n");
        }

        private static int PartTwo(string[] input) 
        {
            int trees = 0;

            //List<int> slopes = new List<int>;
            (int, int)[] slope = {(3,1), (1,1), (7,1), (1,2), (5,1)};
            IEnumerable<int> output = slope.Select(x => PartOne(input, x));
            //new (int, int)[] {(1,1), (5,1), (7,1), (1,2)}.Select(x => PartOne(input, x));
            //System.Console.WriteLine(output);
            int total = 1;
            foreach (int i in output)
            {
                int count = 1;
                System.Console.WriteLine($"{count}: {i}");
                total = i * total;
                count++;
            }

            return total;
        }
        private static int PartOne(string[] input, (int, int) slope) 
        {
            int trees = 0;

            // foreach (string line in input)
            // {
                int lineLength = input[0].Length;
                int totalLength = input.Length;
                int row = 0;
                int column = 0;
                System.Console.WriteLine(totalLength);


                while (row <= 323)
                {
                    //char map = input[row][column];
                    row += slope.Item1;
                    column += 1;//slope.Item2;

                    if (column >= lineLength)
                    {
                        column = column % lineLength;
                    }

                    if (input[row].Substring(column, 1)  == "#")
                    //if (map.ToString()  == "#")
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
        class firstTry
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }

        
    }
}
