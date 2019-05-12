using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_JFink_Final2.Models.Repositories
{
    public class MemberRepository :IMemberRepository
    {
        private readonly AppDbContext _appDbContext;

        public MemberRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Member> GetMembers()
        {
            return _appDbContext.Members;
        }

        public Member GetMemberById(int memberId)
        {
            return _appDbContext.Members.FirstOrDefault(m => m.MemberID == memberId);
        }

        public void addMember(Member newMember)
        {
            throw new NotImplementedException();
        }
    }
}
