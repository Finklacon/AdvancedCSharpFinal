using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public class MockGolfRepository : IGolferRepository
    {
        private List<Golfer> _golfers;


        public MockGolfRepository()
        {
            if (_golfers == null)
            {

            }
        }

        public void InitializeGolfers()
        {
            _golfers = new List<Golfer>
            {
                new Golfer {FirstName = "Justin", LastName = "Fink", Email = "americanfink@gmail.com", MemberID = 1, Age = 29, Gender ="Male", Handicap = 15.5, Username = "fink", Password = "123"},
                new Golfer {FirstName = "Henry", LastName = "Ford", Email = "ford@gmail.com", MemberID = 2, Age = 88, Gender ="Male", Handicap = 24, Username = "ford", Password = "123"},
            };
        }

      

        public Golfer GetGolferById(int golferId)
        {
            return _golfers.FirstOrDefault(g => g.MemberID == golferId);
        }
        public IEnumerable<Golfer> GetGolfers => _golfers;

        public void AddGolfer(Golfer newGolfer)
        {
            _golfers.Add(newGolfer);
        }
    }
}
