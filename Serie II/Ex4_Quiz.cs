using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Qcm
    {
        public string Question;
        public string[] Answers;
        public int Solution;
        public int Weight;
    }
    public Qcm(string question, string[] answers, int solution, int weight) 
    { 
                Question = question; 
                Answers = answers; 
                Solution = solution; 
                Weight = weight;   
    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            
        }

        public static int AskQuestion(Qcm qcm)
        {
            //TODO
            return -1;
        }

        public static bool QcmValidity(Qcm qcm)
        {
            if ( qcm.Answers < 0 && 0 < qcm.Solution < n && qcm.Weight > 0)
            {

                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
