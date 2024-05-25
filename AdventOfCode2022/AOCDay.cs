
namespace AdventOfCode2022
{
    public abstract class AOCDay
    {
        public string InputFileName = string.Empty;

        public AOCDay(string inputFileName)
        {
            InputFileName = Path.Combine("../../../", inputFileName); ;
        }
    }
}
