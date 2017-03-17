using System;

namespace Events
{
    public class AcceptanceOffice 
    {
        //publisher
        public event EventHandler<ScoreReachedEventArgs> ScoreReachedEventHandler;
        protected virtual void OnScoreReached(ScoreReachedEventArgs e)
        {
            EventHandler<ScoreReachedEventArgs> handler = ScoreReachedEventHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}