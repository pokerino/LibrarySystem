using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        private LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void Remove(Member member)
        {
            _context.Members.Remove(_context.Members.Find(member.Id));
        }

        public Member Find(int member)
        {
            return _context.Members.Find(member);
        }

        public void Edit(Member memberChange)
        {
            Member memberTarget = _context.Members.Find(memberChange.Id);
            memberTarget.Name = memberChange.Name;
            memberTarget.personalNr = memberChange.personalNr;
            memberTarget.Loans = memberChange.Loans;
        }

        public IEnumerable<Member> All()
        {
            return _context.Members;
        }
    }
}
