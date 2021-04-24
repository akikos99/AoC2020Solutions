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

            Console.WriteLine($"Part one solution: {PartOne(input)\n}");
            //Console.WriteLine($"Part two solution: {PartTwo(input)\n}");
        }


        public static int PartOne(string[] input) 
        {

            foreach (string word in input)
            {
                //looks like a problem I've done before where each line is actually binary
                //upper half(B, R) = 1, lower half(F, L) = 0
                int total = 0;
                int max = 0;
                string[] line = word.Split(" ");

                if (line[0].Substring(0,1) == "B")
                {
                    total = total + 512;
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring(1,1) == " ")
                {
                    total = total + 256;
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring(2,1) == "B")
                {
                    total = total + 128;
                    
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring(3,1) == "B")
                {
                    total = total + 64;
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring (4,1) == "B")
                {
                    total = total + 32;
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring(5,1) == "B")
                {
                    total = total + 16;
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring(6,1) == "B")
                {
                    total = total + 8;
                }
                else
                {
                    total = total + 0;
                }
                
                if (line[0].Substring(7,1) == "R")
                {
                    total = total + 4;
                }
                else
                {
                    total = total + 0;
                }
                
                if (line[0].Substring(8,1) == "R")
                {
                    total = total + 2;
                }
                else
                {
                    total = total + 0;
                }

                if (line[0].Substring(9,1) == "R")
                {
                    total = total + 1;
                }
                else
                {
                    total = total + 0;
                }

                if (total > max)
                {
                    max = total;
                }

                return max;
            }
            return 0;
        }

        // public static int SolvePartTwo(string[] input) 
        // {

        //     foreach (string word in input)
        //     {
        //     }

        // }
        
    }
}