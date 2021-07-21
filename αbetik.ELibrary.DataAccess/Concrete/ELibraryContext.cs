using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.DataAccess.Concrete.EntityFramework.Mappings;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Concrete
{
    public class ELibraryContext : DbContext
    {
        public ELibraryContext()
        {
            Database.SetInitializer<ELibraryContext>(null);
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PersonRole> PeopleRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonRoleMap());
        }                                                        
        
        
    }

}
