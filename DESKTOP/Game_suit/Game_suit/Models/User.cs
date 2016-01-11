using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Game_suit.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalScores { get; set; }
        public string Email { get; set; }
    }
    public class Rank
    {
        public static int GetScores(DbSet<User> context, int id)
        {
            var user = GetAllUsers(context).Where(item => item != null);

            return (user as User).TotalScores;
        }


        public static List<User> GetAllUsers(DbSet<User> context)
        {
            return new List<User>(context);
        }
    }
}