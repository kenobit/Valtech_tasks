using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameSuit_new.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max Name length - 20 chars")]
        public string Name { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max Login length - 20 chars")]
        [MinLength(6, ErrorMessage = "Min Login length - 6 chars")]
        public string Login { get; set; }
        public int TotalScores { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Max Password length - 30 chars")]
        [MinLength(6, ErrorMessage = "Min Password length - 6 chars")]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
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
