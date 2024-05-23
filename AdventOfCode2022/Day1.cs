using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day1
    {
        private string inputFileName = string.Empty;

        public Day1(string inputFileName)
        {
            this.inputFileName = Path.Combine("../../../", inputFileName);
        }

        public void ParseInputPart1()
        {
            int max = 0;
            int sum = 0;
            Queue<string> inputLines = FileReader.ReadFile(inputFileName);

            while(inputLines.Count() != 0)
            {
                string line = inputLines.Dequeue();
                Console.WriteLine($"Checking line: {line}");

                if (String.IsNullOrEmpty(line))
                {
                    // blank line
                    Console.WriteLine("Blank line detected");
                    if (sum > max) max = sum;
                    sum = 0;

                }
                else
                {
                    sum += Int32.Parse(line);
                    Console.WriteLine($"Adding {line} to sum, new sum: {sum}");

                }
            }

            Console.WriteLine($"Max calories is {max}");

        }
    }
}
