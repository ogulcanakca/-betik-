using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetPeople();
        Person GetByTcNo(string TcNo);
        Person Add(Person person);
        Person Update(Person person);
        void Delete(Person person);
        void Ban(Person person, Book book);


    }
}
