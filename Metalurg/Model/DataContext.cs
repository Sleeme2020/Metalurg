using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalurg.Model
{
    public delegate void DelegateEvent();
    public delegate void OpenForm<T>(T? obj);

    internal static class ContextData
    {
        public static event DelegateEvent DelegateEventProduct;
        public static void GetProduct()
        {
            DelegateEventProduct();
        }
        public static ApplicationContext Context { get; }

       private static User _user;
        public static User User { 
            get
            {
                return _user;
            }
            set 
            {
                if (_user != null) throw new Exception($"Пользователь уже авторизован, текущий {_user}");
                   _user = value;
            }
        }
        static ContextData()
        {
            Context = new ApplicationContext();
        }

        //первый вариант
        //public static void GetUser(User user)
        //{
        //    if (User != null) throw new Exception($"Пользователь уже авторизован, текущий {User}");
        //    User = user;
        //}
    }
}
