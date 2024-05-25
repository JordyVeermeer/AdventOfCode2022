using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day3 : AOCDay
    {
        public Day3(string inputFileName) : base(inputFileName)
        {
        }

        public void ParseInputPart1()
        {
            Queue<string> inputLines = FileReader.ReadFile(InputFileName);

            int sum = 0;

            foreach (string line in inputLines)
            {
                char duplicate;

                // split line in middle to get 2 compartments
                char[] firstCompartment = line.Substring(0, line.Length/2).ToCharArray();
                char[] secondCompartment = line.Substring(line.Length/2).ToCharArray();

                foreach (char c in firstCompartment)
                {
                    if (secondCompartment.Contains(c))
                    {
                        duplicate = c;
                        sum += GetValueForChar(c);
                        break;
                    }
                }
            }

            Console.WriteLine($"The sum of priorities is {sum}");
        }

        private int GetValueForChar(char c)
        {
            int value = c;

            if (Char.IsUpper(c))
            {
                value = c - 38;
            }
            else
            {
                value = c - 96;
            }

            Console.WriteLine($"char {c} has value {value}");

            return value;
        }
    }
}
