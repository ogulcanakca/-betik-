using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PersonRoleMap : EntityTypeConfiguration<PersonRole>
    {
        public PersonRoleMap()
        {
            ToTable(@"PeopleRoles", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.PersonId).HasColumnName("PersonId");
            Property(x => x.RoleId).HasColumnName("RoleId");

        }

    }
}
