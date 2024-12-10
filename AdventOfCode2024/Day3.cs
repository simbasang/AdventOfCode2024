using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    internal class Day3 : IBase
    {
        public int PartOne()
        {
            var input=Helper.ReadInputAllText();

            MatchCollection matches = Regex.Matches(input, @"mul\((\d+),(\d+)\)");

            return matches.Select(x => int.Parse(x.Groups[1].Value)* int.Parse(x.Groups[2].Value)).Sum();
        }

        public int PartTwo()
        {
            var input = Helper.ReadInputAllText();

            string instructionPattern = @"do\(\)|don't\(\)|mul\((\d+),(\d+)\)";
            bool isMulEnabled = true; 
            int sum = 0;

            foreach (Match match in Regex.Matches(input, instructionPattern))
            {
                string matchedText = match.Value;

                isMulEnabled = matchedText == "do()" ? true : matchedText == "don't()" ? false : isMulEnabled;
              
                if (isMulEnabled && match.Groups[1].Success && match.Groups[2].Success)
                    sum += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
            }
            return sum;
        }
    }
}
