using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class MemberRepository : IMemberRepository
    {
        private library_DBEntities db;

        public MemberRepository(library_DBEntities context)
        {
            db = context;
        }

        public bool DeleteMember(Table_Member Member)
        {
            try
            {
                db.Entry(Member).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMember(int MemberId)
        {
            try
            {
                var Member = GetMemberById(MemberId);
                DeleteMember(Member);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Table_Member> GetAllMembers()
        {
            return db.Table_Member.ToList();
        }

        public IEnumerable<Table_Member> GetMemberByFilter(string parameter)
        {
            return db.Table_Member.Where(c => c.Name.Contains(parameter) || c.Family.Contains(parameter) || c.CodeMeli.Contains(parameter) || c.TelephoneNumber.Contains(parameter) || c.Address.Contains(parameter) || c.Email.Contains(parameter)).ToList();
        }

        public Table_Member GetMemberById(int MemberId)
        {
            return db.Table_Member.Find(MemberId);
        }

        public bool InsertMember(Table_Member Member)
        {
            try
            {
                db.Table_Member.Add(Member);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateMember(Table_Member Member)
        {
            try
            {
                var local = db.Set<Table_Member>()
                         .Local
                         .FirstOrDefault(f => f.Id == Member.Id);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(Member).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
