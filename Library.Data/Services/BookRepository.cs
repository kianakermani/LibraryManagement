using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class BookRepository : IBookRepository
    {

        private library_DBEntities db;

        public BookRepository(library_DBEntities context)
        {
            db = context;
        }


        public bool DeleteBook(Table_Book Book)
        {
            try
            {
                db.Entry(Book).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBook(int BookId)
        {
            try
            {
                var Book = GetBookById(BookId);
                DeleteBook(Book);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Table_Book> GetAllBooks()
        {
            return db.Table_Book.ToList();
        }

        public IEnumerable<Table_Book> GetBookByFilter(string parameter)
        {
            return db.Table_Book.Where(c => c.Onvan.Contains(parameter) || c.Nevisande.Contains(parameter) || c.Nasher.Contains(parameter) || c.Category.Contains(parameter)).ToList();
        }

        public Table_Book GetBookById(int BookId)
        {
            return db.Table_Book.Find(BookId);
        }

        public bool InsertBook(Table_Book Book)
        {
            try
            {
                db.Table_Book.Add(Book);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool UpdateBook(Table_Book Book)
        {
            try
            {
                var local = db.Set<Table_Book>()
                         .Local
                         .FirstOrDefault(f => f.Id == Book.Id);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(Book).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
