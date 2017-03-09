using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class MemberService
    {
        MemberRepository _memberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        
        }

        public void Add(long Id, string name)
        {
            bool exists = true;
            foreach (Member existingMember in _memberRepository.All())
            {
                if (existingMember.personalNr == Id)
                {
                    exists = true;
                    System.Windows.Forms.MessageBox.Show("Member already exists");
                    break;
                }
                else
                    exists = false;
            }

            if (!exists)
            {
                _memberRepository.Add(new Member()
                {
                    personalNr = Id,
                    Name = name
                });
                OnUpdate(new EventArgs());
            }
        }
    }
}
