using System;

namespace Events
{
    public class ScoreReachedEventArgs: EventArgs
    {
        public int score;
        public bool accepted;
    }
}