using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly AppDbContext _appDbContext;

        IEnumerable<Scores> IScoreRepository.GetScores =>  GetScores();
        public ScoreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Scores> GetScores()
        {
            return _appDbContext.Scores;
        }

        public void AddScore(Scores newScore)
        {
            throw new NotImplementedException();
        }
    }
}
