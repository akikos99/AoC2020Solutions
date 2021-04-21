using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Day1Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AdventOfCodeDay1Input.txt"));
            List<int> expenses = (Array.ConvertAll(input, s => Int32.Parse(s))).ToList();
            expenses.Sort();

            Console.WriteLine($"Part one solution: {PartOne(expenses)}\n");
            Console.WriteLine($"Part one solution: {PartTwo(expenses)}\n");
        
        }

        public static int PartOne(List<int> List) 
        {
            foreach (int i in List)
            {
                foreach (int y in List)
                {
                    if (i + y == 2020)
                    {
                        return i * y;
                    }
                }
            }

        return 0;
        }

        public static int PartTwo(List<int> List) 
        {
            foreach (int i in List)
            {
                foreach (int y in List)
                {
                    foreach (int z in List)
                    {
                        if (i + y + z == 2020)
                        {
                            return i * y * z;
                        }
                    }
                    
                }
            }

        return 0;
        }
    }
}
