using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TeacherMap:EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            ToTable(@"Teachers", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.TakenBookId).HasColumnName("TakenBookId");
            Property(x => x.TcNo).HasColumnName("TcNo");
            Property(x => x.StarterTime).HasColumnName("StarterTime");
            Property(x => x.SchoolType).HasColumnName("SchoolType");
            Property(x => x.Password).HasColumnName("Password");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.DeadTime).HasColumnName("DeadTime");
            Property(x => x.Age).HasColumnName("Age");
            Property(x => x.Branch).HasColumnName("Branch");
        }
    }
}
