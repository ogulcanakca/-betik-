using DevFramework.Core.Aspects.Postsharp.CacheAspects;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.Aspects.Postsharp.TransactionAspects;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
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
    [CacheRemoveAspect("",typeof(MemoryCacheManager))]
    [LogAspect(typeof(FileLogger))]
    
    public class PersonManager : IPersonService
    {
        private IBookDal _bookDal;
        private IPersonDal _personDal;
        private IPersonService _personService;
  
        public PersonManager(IPersonDal personDal)
        {
            
            _personDal = personDal;
        }
        public PersonManager(IBookDal bookDal, IPersonService personService)
        {
            _personService = personService;
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
        public List<BookDetail> GetirBookDetails(Person person)
        {
            return _personDal.GetBookDetails(person);
        }
        [TransactionScopeAspect]
        public void Ban(Person person, Book book)
        {
            _personService.GetByTcNo("TcNo yaz");
            _bookDal.Delete(book);
            _personDal.Delete(person);
            
        }
    }
}
