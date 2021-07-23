using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using αbetik.ELibrary.Business.Abstract;
using αbetik.ELibrary.Business.Concrete;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.Business.Tests
{
    [TestClass]
    public class PersonManagerTests 
    {
        PersonManager pm = new PersonManager();
        [TestMethod, ExpectedException(typeof(System.NullReferenceException))]
        public void Is_getBookDetails_working()
        {
            pm.GetPeople();
            //var mock = new Mock<IPersonService>();
            //var manager = mock.Object;

            //Mock<IPersonDal> mock = new Mock<IPersonDal>();
            //PersonManager pm = new PersonManager(mock.Object);
            //pm.GetPeople();
            
            //if (x!= null)
            //{
                

            //   throw new Exception("aq");
            //}
        }
    }
}
