using System;
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
            Console.WriteLine(StringUtilities.LongWordsCount("The lord of the rings"));

            Console.WriteLine(StringUtilities.ToSpinalCase("Marcin Jagiela"));
            Console.WriteLine(StringUtilities.ToSpinalCase("the LorD OF thE Rings"));

            Console.WriteLine(StringUtilities.ToPascalCase("marcin jagiela"));
            Console.WriteLine(StringUtilities.ToPascalCase("the LorD OF thE Rings"));

            Console.ReadKey();
        }
    }
}
