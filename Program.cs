using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expected_input_and_output
{
    internal class Program
    { 
            public static int HowManyOccurrences(string mainString, string substring)
        {
            Console.WriteLine("Method HowManyOccurrences Started");
            Console.WriteLine("------------------------------");
            int count = 0;
            int index = mainString.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = mainString.IndexOf(substring, index + 1);
            }

            Console.WriteLine("Method HowManyOccurrences Ended");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            return count;
        }
    }
}
