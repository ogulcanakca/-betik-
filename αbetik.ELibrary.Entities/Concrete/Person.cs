using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik.ELibrary.Entities.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int TakenBookId { get; set; }
        public DateTime DeadTime { get; set; }
        public DateTime StarterTime { get; set; }
        
    }
}
