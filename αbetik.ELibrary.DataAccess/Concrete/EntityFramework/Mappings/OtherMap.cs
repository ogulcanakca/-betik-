using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class OtherMap :EntityTypeConfiguration<Other>
    {
        public OtherMap()
        {
            ToTable(@"Others", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.TakenBookId).HasColumnName("TakenBookId");
            Property(x => x.TcNo).HasColumnName("TcNo");
            Property(x => x.StarterTime).HasColumnName("StarterTime");
            Property(x => x.Occupation).HasColumnName("Occupation");
            Property(x => x.Password).HasColumnName("Password");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.DeadTime).HasColumnName("DeadTime");
            Property(x => x.Age).HasColumnName("Age");
        }
    }
}
