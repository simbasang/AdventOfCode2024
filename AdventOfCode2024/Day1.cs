using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    internal class Day1: IBase
    {
        public int PartOne()
        {
            var input = Helper.ReadInput()
            .Select(line => Regex.Split(line, @"\s+").Select(int.Parse).ToList())
            .ToList();

            var firstList = input.Select(pair => pair[0]).OrderBy(x => x).ToList();
            var secondList = input.Select(pair => pair[1]).OrderBy(x => x).ToList();

             return firstList
                .Zip(secondList, (first, second) => Math.Abs(first - second))
                .Sum();

        }

        public int PartTwo()
        {
            var input = Helper.ReadInput()
            .Select(line => Regex.Split(line, @"\s+").Select(int.Parse).ToList())
            .ToList();

            var firstList = input.Select(pair => pair[0]);
            var secondList = input.Select(pair => pair[1]);

            return firstList.Sum(x => secondList.Count(z => z == x) * x);

        }
    }
}
