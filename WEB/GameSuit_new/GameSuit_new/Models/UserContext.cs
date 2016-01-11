using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameSuit_new.Models
{
    public class UserContext:IDisposable
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public void Dispose()
        {
            Users = null;
        }
    }
}