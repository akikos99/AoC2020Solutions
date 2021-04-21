using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Day2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AoCDay2Input.txt"));

            Console.WriteLine($"Part one solution: {PartOne(input)}");
            Console.WriteLine($"Part two solution: {PartTwo(input)}");
        }


        public static int PartOne(string[] input) 
        {
            int accepted = 0;

            foreach (string word in input)
            {
                int count = 0;
                string[] semiColonSplit = word.Split(":"); //separates string into two parts, before and after the :
                string password = semiColonSplit[1];
                string[] spaceSplit = semiColonSplit[0].Split(" "); //separates string into letter and min/max
                string letter = spaceSplit[1];
                string[] dashSplit = spaceSplit[0].Split("-"); //separates string into min and max
                string min = dashSplit[0]; //lower amount of char
                string max = dashSplit[1]; //upper amount of char

                //count = password.Count(f => f == letter);
                count = password.Split(letter).Length - 1;

                if (count >= int.Parse(min) && count <= int.Parse(max))
                {
                    accepted++; // = accepted + 1;
                }
            }
           
           return accepted;
        }

        public static int PartTwo(string[] input) 
        {
            int accepted = 0;

            foreach (string word in input)
            {

                string[] semiColonSplit = word.Split(":"); //separates string into two parts, before and after the :
                string password = semiColonSplit[1];
                string[] spaceSplit = semiColonSplit[0].Split(" "); //separates string into letter and min/max
                string letter = spaceSplit[1];
                string[] dashSplit = spaceSplit[0].Split("-");
                string posOne = dashSplit[0]; //lower amount of char
                string posTwo = dashSplit[1]; //upper amount of char


                string posOneChar = password.Substring(int.Parse(posOne), 1);
                string posTwoChar = password.Substring(int.Parse(posTwo), 1);

                //System.Console.WriteLine(letter);

                if ((posOneChar == letter && posTwoChar != letter) || (posOneChar != letter && posTwoChar == letter))
                {
                    accepted++; // = accepted + 1;
                }
            }
           
           return accepted;
        }
        
    }
}
