using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using αbetik.ELibrary.Entities.Concrete;

namespace αbetik.ELibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable(@"Books", @"dbo");
            HasKey(x => x.Id);
            Property(x => x.BookId).HasColumnName("BookId");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Author).HasColumnName("Author");
            Property(x => x.Type).HasColumnName("Type");
            Property(x => x.PageNumber).HasColumnName("PageNumber");
            Property(x => x.Translator).HasColumnName("Translator");


        }
    }
}
