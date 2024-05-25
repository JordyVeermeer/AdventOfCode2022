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

        public void ParseInputPart2() {
            List<int> topThree = [];
            int sum = 0;
            Queue<string> inputLines = FileReader.ReadFile(inputFileName);

            while (inputLines.Count() != 0)
            {
                string line = inputLines.Dequeue();
                Console.WriteLine($"Checking line: {line}");

                if (String.IsNullOrEmpty(line))
                {
                    // blank line
                    Console.WriteLine("Blank line detected");

                    if (topThree.Count < 3)
                    {
                        topThree.Add(sum);
                        topThree.Sort((a, b) => b.CompareTo(a));
                        Console.WriteLine("Top 3 sorted");
                        topThree.ForEach(Console.WriteLine);
                    } else
                    {
                        if (sum > topThree[2])
                        {
                            if (sum > topThree[1])
                            {
                                if (sum > topThree[0])
                                {
                                    topThree[2] = topThree[1];
                                    topThree[1] = topThree[0];

                                    topThree[0] = sum;

                                    Console.WriteLine($"Plaats 1 vervangen door {sum}");

                                }
                                else
                                {
                                    topThree[2] = topThree[1];
                                    topThree[1] = sum;

                                    Console.WriteLine($"Plaats 2 vervangen door {sum}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Plaats 3 vervangen door {sum}");
                                topThree[2] = sum;
                            }
                        }
                    }

                    sum = 0;

                }
                else
                {
                    sum += Int32.Parse(line);
                    Console.WriteLine($"Adding {line} to sum, new sum: {sum}");

                }
            }

            topThree.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"Top 3 elves are carrying {topThree.Sum()} calories");
        }
    }
}
