using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using αbetik.ELibrary.Business.Concrete;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.Business.Tests
{
    [TestClass]
    public class PersonManagerTests
    {
        
        [TestMethod]
        public void Is_getBookDetails_working()
        {
            Person person = new Person();
            var mock = new Mock<IPersonDal>();

            var manager = new PersonManager(mock.Object);
            //if (manager.GetirBookDetails(person) == null)
            //{
            //    throw new Exception("nuul geldi");
            //}

            
           
        }
    }
}
