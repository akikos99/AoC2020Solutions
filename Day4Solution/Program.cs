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
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay4Solution.txt"));
            List<string> inputs = CreateList(input);
            Console.WriteLine($"Part one solution: {PartOne(inputs)}\n");
            //Console.WriteLine($"Part two solution: {PartTwo(input)}\n");
        }

        

        public static List<string> CreateList(string[] input)
        {
           List<string> inputList = new List<string>();
        
           foreach (string person in input)
           {
               if (person == "\n")
               {
                   inputList.Add(person);
               }
               System.Console.WriteLine(inputList);
           }
           return inputList;
        }
        
        public static int PartOne(List<string> input) 
        {
            //Need to split by \n for each separate person
            //so maybe 
            int total = 0;

            foreach (string attributes in input)
            {
                bool contBYR = attributes.Contains("byr");
                bool contIYR = attributes.Contains("iyr");
                bool contEYR = attributes.Contains("eyr");
                bool contHGT = attributes.Contains("hgt");
                bool contHCL = attributes.Contains("hcl");
                bool contECL = attributes.Contains("ecl");
                bool contPID = attributes.Contains("pid");
                bool contCID = attributes.Contains("cid");
                
                if (contBYR == true && contIYR == true && contEYR == true && contHGT == true && contHCL == true && contECL == true && contPID == true)
                {
                    total += 1;
                }
                else
                {
                    
                }
        
            }

            return total;
            
        }

        // public static int PartTwo(string[] input) 
        // {
            
        // }
        
    }
}
