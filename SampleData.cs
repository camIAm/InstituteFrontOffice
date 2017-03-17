using System;
using System.Collections.Generic;

namespace Events 
{
    public class SampleData
        {
        static List<Institute> _institutes;
        static List<Applicant> _applicants;
        static List<Applicant> Applicants {get {return _applicants;}}
        static List<Institute> Institutes {get{return _institutes;}}

        public static class ApplicantPool
        {
            static string[] firstnames = new string[5]{"jim","tom", "jack","jake","mitch"};
            static string[] lastnames = new string[5]{"johnson","thomas", "jackson","montgomery","jackson"};
            static int[] scores = new int[5]{1500, 1200, 1100, 1450, 1350};
            public static List<Applicant> GetApplicants()
            {
                List<Applicant> applicantPool = new List<Applicant>();
                Applicant applicant;
                byte[] randomByteArr = new byte[20];
                Random rnd = new Random();
                rnd.NextBytes(randomByteArr);
                
                Console.WriteLine("starting random mix and match applicants");
                for(int i=randomByteArr.GetLowerBound(0);
                i<=randomByteArr.GetUpperBound(0);
                i++){
                    applicant = new Applicant{
                        FirstName = firstnames[randomByteArr[i] % firstnames.Length],
                        LastName = lastnames[randomByteArr[i] % lastnames.Length],
                        StandardizedTest = scores[randomByteArr[i] % scores.Length]
                    };
                    _applicants.Add(applicant);
                }
                return _applicants;
            }
        }
        public static class PerspectiveInstitutes 
        {
            static string[] instituteArr = new string[5]{"USC", "Clemson", "Citadel", "CofC", "UGA"};
            static int[] instituteMinScores = new int[5]{1500, 1455, 1100, 1150, 1000};
            static Institute institute;
            public static List<Institute> RandomizedInstitutes(){
            Random rnd = new Random();
            byte[] byteArr = new byte[20];
            rnd.NextBytes(byteArr);
        
            for(int i = byteArr.GetLowerBound(0);
                i<= byteArr.GetUpperBound(0);
                i++)
                {
                    institute = new Institute
                    {
                        InstituteName = instituteArr[byteArr[i] % instituteArr.Length],
                        MinimumScore = instituteMinScores[byteArr[i]% instituteMinScores.Length]
                    };
                    _institutes.Add(institute);
                }
                return _institutes;
            }
        }
    }
}
    
