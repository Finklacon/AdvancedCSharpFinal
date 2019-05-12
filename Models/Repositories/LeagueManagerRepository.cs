using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models.Repositories
{
    public class LeagueManagerRepository : ILeagueManagerRepository
    {
        private readonly AppDbContext _appDbContext;

        public LeagueManagerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<LeagueManager> GetLeagueManagers()
        {
            return _appDbContext.LeagueManagers;
        }

        public LeagueManager GetLeagueManagerById(int memberId)
        {
            return _appDbContext.LeagueManagers.FirstOrDefault(lm => lm.MemberID == memberId);
        }

        public void addLM(LeagueManager newLM)
        {
            throw new NotImplementedException();
        }
    }
}
