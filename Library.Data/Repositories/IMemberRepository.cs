using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public interface IMemberRepository
    {
        List<Table_Member> GetAllMembers();
        IEnumerable<Table_Member> GetMemberByFilter(string parameter);
        Table_Member GetMemberById(int MemberId);
        bool InsertMember(Table_Member Member);
        bool UpdateMember(Table_Member Member);
        bool DeleteMember(Table_Member Member);
        bool DeleteMember(int MemberId);
    }
}
