using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik.ELibrary.Entities.Concrete
{
    public class PersonRole : IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
    }
}
