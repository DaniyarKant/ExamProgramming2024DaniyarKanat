﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace UtilitiesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringUtilities.LongWordsCount("Marcin Jagiela"));
            Console.ReadKey();
        }
    }
}