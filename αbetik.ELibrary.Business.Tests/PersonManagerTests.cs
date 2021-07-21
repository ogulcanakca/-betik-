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
        [TestMethod]
        public void Is_getBookDetails_working()
        {
            Person person = new Person();
            var mock = new Mock<IPersonService>();
            var manager = mock.Object;
            

           
            if (manager.GetPeople()==null)
            {
                throw new Exception("aq");
            }
        }
    }
}
