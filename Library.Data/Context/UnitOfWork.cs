using Library.Data.Repositories;
using Library.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Context
{
    public class UnitOfWork : IDisposable
    {
        library_DBEntities db=new library_DBEntities();

        private IBookRepository _BookRepository;
        public IBookRepository BookRepository
        {
            get
            {
                if (_BookRepository == null)
                {
                    _BookRepository = new BookRepository(db);
                }

                return _BookRepository;
            }

            set
            {

            }
        }

        private IMemberRepository _MemberRepository;
        public IMemberRepository MemberRepository
        {
            get
            {
                if (_MemberRepository == null)
                {
                    _MemberRepository = new MemberRepository(db);
                }

                return _MemberRepository;
            }

            set
            {

            }
        }


        private IAmanatRepository _AmanatRepository;
        public IAmanatRepository AmanatRepository
        {
            get
            {
                if(_AmanatRepository == null)
                {
                    _AmanatRepository=new AmanatRepository(db);
                }
                return _AmanatRepository;
            }

            set
            {

            }
        }

        private GenericRepository<Table_Users> _loginRepository;
        public GenericRepository<Table_Users> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Table_Users>(db);
                }
                return _loginRepository;
            }
        }



        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }


        
}
