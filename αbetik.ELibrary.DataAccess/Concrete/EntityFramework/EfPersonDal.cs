using DevFramework.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, ELibraryContext>, IPersonDal
    {
        public List<BookDetail> GetBookDetails(Person person, int Id)
        {
            using (ELibraryContext context = new ELibraryContext())
            {
                var result = from books in context.Books
                             join people in context.People
                             on books.BookId equals person.TakenBookId
                             select new BookDetail
                             {

                                 BookId = person.TakenBookId,
                             };
                return result.ToList();
            }
        }
    }
}
