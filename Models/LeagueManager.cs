using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class LeagueManager : Member
    {
        public int LeagueManagerID { get; set; }
        public int NumOfTeams { get; set; }
        [NotMapped]
        public List<string> Teams { get; set; }
        public List<Golfer> golfers { get; set; }
    }
}
