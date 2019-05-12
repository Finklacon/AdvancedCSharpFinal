using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class GolferRepository : IGolferRepository
    {
        private readonly AppDbContext _appDbContext;

        IEnumerable<Golfer> IGolferRepository.GetGolfers => GetGolfers();

        public GolferRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Golfer> GetGolfers()
        {
            return _appDbContext.Golfers;
        }

        public void AddGolfer(Golfer newGolfer)
        {
            _appDbContext.Add(newGolfer);
        }

        public Golfer GetGolferById(int memberId)
        {
            return _appDbContext.Golfers.FirstOrDefault(g => g.MemberID == memberId);
        }
      
    }
}
