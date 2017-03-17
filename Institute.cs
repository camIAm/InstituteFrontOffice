using System;

namespace Events
{
    public class Institute
    {
        internal string InstituteName{get;set;}
        public int MinimumScore{get;set;}
        public Institute(){}
        
        public Institute(string instituteName, int minScore)
        {
            InstituteName = instituteName;
            //pub.RaiseCustomEvent += HandleCustomEvent;
            MinimumScore = minScore;
        }
              protected virtual void OnScoreReached(ScoreReachedEventArgs e)
        {
            System.Console.WriteLine("Institue subscriber");
        }
        /* 
        void HandleCustomEvent(object sender, AcceptanceLetter e)
        {  
            Console.WriteLine( "applicant:{0} would like you to attend their school as of {1}\n" , InstituteName, e.Message);
        }
        */
    }

}
