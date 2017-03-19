using System;

namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AcceptanceOffice acceptance = new AcceptanceOffice();
            Applicant applicant = new Applicant();
            acceptance.Add(3);
            acceptance.ScoreReachedEventHandler += c_ThresholdReached;
           // acceptance.ScoreReachedEventHandler += applicant.OnScoreReached;

            Console.WriteLine("Hello World!");
        }
         static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold,  e.TimeReached);
            Environment.Exit(0);
        }
    }
}
