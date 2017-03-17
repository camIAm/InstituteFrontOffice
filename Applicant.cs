
namespace Events
{
      public class Applicant
    {
        // could implement a 'stadardized test' that uses a factory to return respective test act,sat,gate,mcat,gmat,gre
        public string firstName, lastName;
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string FullName{get{return FirstName + " " + LastName;}}
        public int StandardizedTest{get;set;}
        public Applicant(){}
        public Applicant(string fname, string lname, int standardTest)
        {
            firstName = fname;
            lastName = lname;
            StandardizedTest = standardTest;
        } 
        public override string ToString(){
            return FirstName.ToString();
        }
        protected virtual void OnScoreReached(ScoreReachedEventArgs e)
        {
                System.Console.WriteLine("applicant subscriber");
        }
    }
}