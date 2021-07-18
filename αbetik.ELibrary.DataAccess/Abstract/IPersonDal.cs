using DevFramework.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Abstract
{
    public interface IPersonDal : IEntityRepository<Person>
    {
        List<BookDetail> GetBookDetails(Person person, int Id);
    }
}
