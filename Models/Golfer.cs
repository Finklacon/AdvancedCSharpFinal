using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class Golfer : Member
    {
        public double Handicap { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Distance myDistance { get; set; }
        public Scores myScores { get; set; }

    }
}
