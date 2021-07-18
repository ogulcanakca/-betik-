using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik.ELibrary.Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public string Type { get; set; }
        public string Translator { get; set; }
    }
}
