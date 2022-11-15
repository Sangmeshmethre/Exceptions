using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");


            Console.WriteLine("Enter your Mood:");
            string message = Console.ReadLine();
            //Creating object of MoodAnalyser class

            MoodAnalyser moodobj = new MoodAnalyser(message);


            Console.WriteLine(moodobj.AnalyseMood());
        }
    }
}