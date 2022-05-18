using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
