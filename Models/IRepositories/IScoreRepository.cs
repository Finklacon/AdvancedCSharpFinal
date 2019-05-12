using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
   
        public interface IScoreRepository
        {
            IEnumerable<Scores> GetScores { get; }

            void AddScore(Scores newScore);

    }
        public class MemoryScoreRepository : IScoreRepository
        {
            private List<Scores> scores = new List<Scores>
        {
            new Scores { numEagles = 0, numBirdies = 1, numPars = 10, numBogeys = 2, numDoubleBogeys = 5, frontNineScore = 43, backNineScore = 50, totalPutts = 33, totalScore = 93 },
            new Scores { numEagles = 0, numBirdies = 3, numPars = 8, numBogeys = 2, numDoubleBogeys = 5, frontNineScore = 43, backNineScore = 50, totalPutts = 33, totalScore = 93 },
            new Scores { numEagles = 0, numBirdies = 4, numPars = 10, numBogeys = 3, numDoubleBogeys = 1, frontNineScore = 45, backNineScore = 42, totalPutts = 33, totalScore = 87 },
            new Scores { numEagles = 0, numBirdies = 5, numPars = 11, numBogeys = 1, numDoubleBogeys = 1, frontNineScore = 35, backNineScore = 50, totalPutts = 33, totalScore = 85 }

        };
            public IEnumerable<Scores> GetScores => scores;


        public void AddScore(Scores newScore)
        {
            scores.Add(newScore);
        }
    }
    
}
