using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//Extraordinarily long method of solving, however

namespace Day8Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay8Input.txt"));

            Console.WriteLine($"Part one solution: {PartOne(input)}");
            //Console.WriteLine($"Part two solution: {PartTwo(input)\n}");
        }


        public static int PartOne(string[] input) 
        {
            //just need to figure out where the infinite loop starts.
            int acc = 0;
            //int count = 0;
            bool test = true;
            int index = 0;

            while (test == true)
            {
                string[] spaceSep = input[index].Split(" ");
                string operation = spaceSep[0];
                string argument = spaceSep[1];

                //System.Console.WriteLine(operation);
                //int index = 0;

                if (operation == "acc")
                {
                    acc = acc + int.Parse(argument);
                    index ++;
                }

                else if (operation == "jmp")
                {
                    //jump spaceSep[1] amount
                    index = index + int.Parse(argument);

                    //word.Skip(int.Parse(argument));
                }

                else
                {
                    //do nothing
                    index ++;
                }
            }
            return acc;
        }

        // public static int SolvePartTwo(string[] input) 
        // {

        //     foreach (string word in input)
        //     {
        //     }

        // }
        
    }
}