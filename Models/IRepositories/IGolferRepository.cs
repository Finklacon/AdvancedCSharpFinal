using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models
{
    public interface IGolferRepository 
    {
        IEnumerable<Golfer> GetGolfers { get; }

        Golfer GetGolferById(int memberId);

        void AddGolfer(Golfer newGolfer);
    }
    public class MemoryGolferRepository : IGolferRepository
    {
        private List<Golfer> golfers = new List<Golfer>
        {
            new Golfer { FirstName = "Justin", LastName = "Fink", Age = 29, Email = "dakrlonz@hotmail.com", Gender = "Male", Handicap = 18.8, MemberID = 1, Username = "Finklacon", Password = "123"},
            new Golfer { FirstName = "Kyle", LastName = "Marley", Age = 33, Email = "@.com", Gender = "Male", Handicap = 11, MemberID = 2, Username = "Marley", Password = "123"},
            new Golfer { FirstName = "Scott", LastName = "Smith", Age = 24, Email = "@.com", Gender = "Male", Handicap = 21, MemberID = 3, Username = "Smith", Password = "123"},
            new Golfer { FirstName = "Ramon", LastName = "Casias", Age = 31, Email = "@.com", Gender = "Male", Handicap = 25.8, MemberID = 4, Username = "Casias", Password = "123"},
            new Golfer { FirstName = "William", LastName = "Dietz", Age = 30, Email = "@.com", Gender = "Male", Handicap = 1.8, MemberID = 5, Username = "Dietz", Password = "123"}
        }; 

        public IEnumerable<Golfer> GetGolfers => golfers;

        public void AddGolfer(Golfer newGolfer)
        {
            golfers.Add(newGolfer);
        }

         public Golfer GetGolferById(int memberId)
         {
              return golfers.FirstOrDefault(g => g.MemberID == memberId);
        }
    }

}
