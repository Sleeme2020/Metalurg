using Microsoft.EntityFrameworkCore;
using Model;


namespace Metalurg.Model
{
    internal static class UserBehavior
    {

        public static void OpenForm(User production)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        public static User[] GetUsers() 
        {
            ContextData.Context.Users.Load();
            return ContextData.Context.Users.ToArray();
        }
        public static void AddUser(User user)
        {
            if (ContextData.Context.Users.Where(u => u.Login == user.Login).Count() == 0)
                ContextData.Context.Users.Add(user);
            else
                throw new Exception("Пользователь уже есть");
            ContextData.Context.SaveChanges();
        }

        public static void RemoveUser(User user) 
        { 
            var us = ContextData.Context.Users.FirstOrDefault(u => u.Login == user.Login);
            if(us != null)
            {
                ContextData.Context.Users.Remove(us);
                ContextData.Context.SaveChanges();
                return;
            }

            throw new Exception("Пользователь не существовал");

        }
        public static User LoginUser(string login, string pas)
        {
            var us = ContextData.Context.Users.FirstOrDefault(u => u.Login == login && u.Password == pas);
            return us ?? throw new Exception("Не верная авторизация");
        }
    }
}
