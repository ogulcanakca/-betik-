using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using αbetik.ELibrary.Business.Concrete;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.Business.Tests
{
    [TestClass]
    public class PersonManagerTests
    {
        Student student = new Student();
        //private PersonManager _personManager;
        //public PersonManagerTests(PersonManager personManager)
        //{
        //    _personManager = personManager;
        //}
        [TestMethod]
        public void Is_getBookDetails_working()
        {
            
            var mock = new Mock<IBookDal>();
            //_personManager.GetirBookDetails(person);
            var manager = new PersonManager(mock.Object);
            if (manager.GetirBookDetails(student, student.TakenBookId)==null)
            {
                throw new Exception("aq");
            }
            //manager.GetirBookDetails();
            
               
            
           
        }
    }
}
