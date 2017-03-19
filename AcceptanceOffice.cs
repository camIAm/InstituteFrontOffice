using System;

namespace Events
{
    public class AcceptanceOffice 
    {
        //publisher
        int total;
        int threshold = 0;
        
        //public event EventHandler<ScoreReachedEventArgs> ScoreReachedEventHandler;
        public event EventHandler<ThresholdReachedEventArgs> ScoreReachedEventHandler;
        protected void OnScoreReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ScoreReachedEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }
         public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnScoreReached(args);
            }
        }
    }
}