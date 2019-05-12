using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class Scores
    {
        [Key]
        public int scoreId { get; set; }

        public int numEagles { get; set; }
        public int numBirdies { get; set; }
        public int numPars { get; set; }
        public int numBogeys { get; set; }
        public int numDoubleBogeys { get; set; }
        public int totalPutts { get; set; }
        public int totalScore { get; set; }
        public int frontNineScore { get; set; }
        public int backNineScore { get; set; }

        public int getScore()
        {
            int scoreToPar = 0;

            if (numEagles > 0)
            {
                for (int i = 0; i < numEagles; i++)
                {
                    scoreToPar = scoreToPar - 2;
                }
            }
            if(numBirdies > 0)
            {
                for (int i = 0; i < numBirdies; i++)
                {
                    scoreToPar = scoreToPar - 1;
                }
            }
            if (numBogeys > 0)
            {
                for (int i = 0; i < numBogeys; i++)
                {
                    scoreToPar = scoreToPar + 1;
                }
            }
            if (numDoubleBogeys > 0)
            {
                for (int i = 0; i < numDoubleBogeys; i++)
                {
                    scoreToPar = scoreToPar + 2;
                }
            }
            return scoreToPar;
        }
        
    }
}
