using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Business.Abstract;
using αbetik.ELibrary.Business.ValidationRules.FluentValidation;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.DataAccess.Concrete;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IBookDal _bookDal;
        private IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
           
            _personDal = personDal;
        }
        public PersonManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        [FluentValidationAspect(typeof(PersonValidator))]
        public Person Add(Person person)
        {
            return _personDal.Add(person);
        }

        public void Delete(Person person)
        {
             _personDal.Delete(person);
        }

        public Person GetByTcNo(string TcNo)
        {
            return _personDal.Get(p=>p.TcNo == TcNo);
        }

        public List<Person> GetPeople()
        {
            return _personDal.GetList();
        }

        public Person Update(Person person)
        {
            return _personDal.Update(person);
        }
        public List<BookDetail> GetirBookDetails(Person person, int Id)
        {
            return _personDal.GetBookDetails(person, person.TakenBookId);
        }
    }
}
