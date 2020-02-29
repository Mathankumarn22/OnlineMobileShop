using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMobileShop.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineMobileShop.Respository
{
    public class UserRespo
    {
        
      
        public static void Add(Account user)
        {
            DBContext dBContext = new DBContext();
            dBContext.account.Add(user);
            dBContext.SaveChanges();
        }
        //public static void Delete(int userID)
        //{
        //    Account user = GetuserID(userID);
        //    if (user != null)
        //        userList.Remove(user);
        //}
        //public static void Update(Account user)
        //{
        //    Account userValue = userList.Find(id => id.UserID == user.UserID);
        //    userValue.UserID = user.UserID;
        //    userValue.Name = user.Name;
        //    userValue.PhoneNumber = user.PhoneNumber;
        //    userValue.MailID = user.MailID;
        //}
        //public static Account GetuserID(int userID)
        //{
        //    return userList.Find(id => id.UserID == userID);
        //}
        //public static bool Login(string mailId, string Password)
        //{
        //    foreach(Account account in userList)
        //    {
        //        if(account.MailID == mailId && account.Password == Password)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        public List<Account> GetUser()
        {
            DBContext dBContext = new DBContext();
            return dBContext.account.ToList();
        }
    }
}
