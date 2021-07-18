using DevFramework.Core.DataAccess.NHihabernate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Business.Abstract;
using αbetik.ELibrary.Business.Concrete;
using αbetik.ELibrary.DataAccess.Abstract;
using αbetik.ELibrary.DataAccess.Concrete;
using αbetik.ELibrary.DataAccess.Concrete.EntityFramework;

namespace αbetik.ELibrary.Business.DependecyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonManager>().InSingletonScope();
            Bind<IPersonDal>().To<EfPersonDal>().InSingletonScope();
            Bind<DbContext>().To<ELibraryContext>();

            Bind<IBookService>().To<BookMananger>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();
            //Bind<NHibernateHelper>().To<SqlServerHelper>().InSingletonScope();

        }
    }
}
