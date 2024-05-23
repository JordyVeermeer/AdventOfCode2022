using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class FileReader
    {
        public static Queue<string> ReadFile(string filePath)
        {
            Queue<string> queue = new Queue<string>();
            string? line;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        queue.Enqueue(line);
                        line = sr.ReadLine();
                    }
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            return queue;
        }
    }
}
