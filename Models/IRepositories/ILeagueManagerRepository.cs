using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public interface ILeagueManagerRepository
    {
        IEnumerable<LeagueManager> GetLeagueManagers();

        LeagueManager GetLeagueManagerById(int memberId);

        void addLM(LeagueManager newLM);
    }
}
