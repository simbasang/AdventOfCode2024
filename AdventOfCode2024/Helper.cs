﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public static class Helper
    {

        public static string[] ReadInputByLine() 
        {
            return File.ReadAllLines("./input.txt"); 
        }
        public static string ReadInputAllText()
        {
            return File.ReadAllText("./input.txt");
        }
    }
}
