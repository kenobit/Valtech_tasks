using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    class UserContext:DbContext
    {
        public DbSet<Person> People{ get; set; }
    }

    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}