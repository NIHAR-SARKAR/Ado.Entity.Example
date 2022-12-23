using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ado.Entity;

namespace AdoEntityTest.Entity
{
    [Table("Users")]
    class Users:AdoBase
    {
        [Primary]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        [Column("DOB")]
        public DateTime DateOfBirth { get; set; }
    }
}
