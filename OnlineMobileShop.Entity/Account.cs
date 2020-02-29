using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMobileShop.Entity
{
    public class Account
    {
        [Key]
        public int UserID { get; set; }

        public string Name { get; set; }

      
        public long PhoneNumber { get; set; }
        public Gender Gender { get; set; }

        public string MailID { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public Account()
        {

        }
    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
