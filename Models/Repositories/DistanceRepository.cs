using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class DistanceRepository : IDistanceRepository
    {
        private readonly AppDbContext _appDbContext;

        IEnumerable<Distance> IDistanceRepository.GetDistance() => GetDistance();
        public DistanceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Distance> GetDistance()
        {
            return _appDbContext.Distances;
        }

        public void AddDistance(Distance newDistances)
        {
            _appDbContext.Add(newDistances);
        }
    }
}
