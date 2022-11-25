using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT.Models
{
    internal class ScoresStudent
    {
        private string studentId;
        private string studentName;
        private string scoresCSharp2;
        private string scoresSql2;
        private string scoresAgile;
        private string scoresEnglish21;
        private double averageScore;

        public ScoresStudent(string studentId, string studentName, string scoresCSharp2, string scoresSql2, string scoresAgile, string scoresEnglish21, double averageScore)
        {
            StudentId = studentId;
            StudentName = studentName;
            ScoresCSharp2 = scoresCSharp2;
            ScoresSql2 = scoresSql2;
            ScoresAgile = scoresAgile;
            ScoresEnglish21 = scoresEnglish21;
            AverageScore = averageScore;
        }

        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string ScoresCSharp2 { get; set; }
        public string ScoresSql2 { get; set; }
        public string ScoresAgile { get; set; }
        public string ScoresEnglish21 { get; set; }
        public double AverageScore { get; set; }

        

        
    }
}
