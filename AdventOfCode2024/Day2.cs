using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    internal class Day2 : IBase
    {
        public int PartOne()
        {
            var reports = Helper.ReadInput()
            .Select(line => Regex.Split(line, @"\s+").Select(int.Parse).ToList())
            .ToList();


            return reports.Count(report => IsSafeReport(report));
        }

        public int PartTwo()
        {
            var reports = Helper.ReadInput()
           .Select(line => Regex.Split(line, @"\s+").Select(int.Parse).ToList())
           .ToList();

            return reports.Count(report => IsSafeReport(report));
        }

        
        private bool IsSafeReport(List<int> report)
        {
            if (IsSafeWithoutModification(report))
                return true;

            for (int i = 0; i < report.Count; i++)
            {
                var modifiedReport = new List<int>(report);
                modifiedReport.RemoveAt(i);

                if (IsSafeWithoutModification(modifiedReport))
                    return true;
            }

            return false;
        }

        private bool IsSafeWithoutModification(List<int> report)
        {
            var isIncreasing = report[0] < report[1];
            for (int i = 0; i < report.Count - 1; i++)
            {
                var diff = report[i + 1] - report[i];

                if ((Math.Abs(diff) < 1 || Math.Abs(diff) > 3)
                    || (isIncreasing && diff < 0 || !isIncreasing && diff > 0))
                    return false;
            }
            return true;
        }
    }
}
