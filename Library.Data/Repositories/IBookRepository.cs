using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public interface IBookRepository
    {
        List<Table_Book> GetAllBooks();
        IEnumerable<Table_Book> GetBookByFilter(string parameter);
        Table_Book GetBookById(int BookId);
        bool InsertBook(Table_Book Book);
        bool UpdateBook(Table_Book Book);
        bool DeleteBook(Table_Book Book);
        bool DeleteBook(int BookId);
    }
}
