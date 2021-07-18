using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using αbetik.ELibrary.Business.Concrete;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.Entities.ComplexTypes;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Tests
{
    [TestClass]
    public class OperationsWithPeople
    {
        
        [TestMethod]
        public void People_kullanarak_teacher_other_book_student_geliyor_mu()
        {

            var mock = new Mock<IBookDal>();
            var comelist = mock.Setup(b => b.GetBookDetails());
            var manager = new PersonManager(mock.Object);
            var asd = manager.GetBookDetails();
            if (asd ==null)
            {
                throw new Exception("sa");
            }
        }

    }
}

