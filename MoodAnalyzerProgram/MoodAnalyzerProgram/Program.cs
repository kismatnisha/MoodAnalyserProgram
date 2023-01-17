using MoodAnalyzerProgram;

namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How is your mood Happy or Sad");
            string message = Console.ReadLine();
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Console.WriteLine(moodAnalyzer.AnalyseMood);

        }
    }
}