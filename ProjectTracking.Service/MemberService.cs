using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracking.Data.Infrastructure;
using ProjectTracking.Data.Repositories;
using ProjectTracking.Model;

namespace ProjectTracking.Service
{
   
    public class MemberService
    {
       readonly IMemberRepository _memberRepository=new MemberRepository();

        public IEnumerable<Member> GetallMembers()
        {
            return _memberRepository.GetAll;
        }
    }
}
