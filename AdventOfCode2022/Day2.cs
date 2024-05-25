using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class Day2 : AOCDay
    {
        public Day2(string inputFileName) : base(inputFileName)
        {

        }

        public void ParseInputPart1()
        {
            // X = Rock = 1, Y = Paper = 2, Z = Scissors = 3
            // Win = 6, Draw = 3, Lose = 0

            Queue<string> inputLines = FileReader.ReadFile(InputFileName);

            int totalScore = 0;

            Dictionary<char, int> pointsPerChoice = new Dictionary<char, int>()
            {
                {'X', 1},
                {'Y', 2},
                {'Z', 3}
            };

            foreach (string line in inputLines)
            {
                int roundScore = 0;

               /* Console.WriteLine($"opponent: {line.Split(' ')[0]}");
                Console.WriteLine($"me: {line.Split(' ')[1]}");*/

                char opponent = char.Parse(line.Split(' ')[0]);
                char myChoice = char.Parse(line.Split(' ')[1]);

                // check score for choice
                roundScore += pointsPerChoice[myChoice];

                // check if you win, draw or lose
                switch (opponent)
                {
                    case 'A':
                        if (myChoice == 'X') roundScore += 3;
                        if (myChoice == 'Y') roundScore += 6;
                        break;

                    case 'B':
                        if (myChoice == 'Y') roundScore += 3;
                        if (myChoice == 'Z') roundScore += 6;
                        break;

                    case 'C':
                        if (myChoice == 'Z') roundScore += 3;
                        if (myChoice == 'X') roundScore += 6;
                        break;
                }

                // add roundscore to totalscore
                totalScore += roundScore;
            }

            Console.WriteLine($"Total score is: {totalScore}");
        }
    }
}
