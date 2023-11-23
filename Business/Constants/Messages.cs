using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı eklendi";
        public static string UserNotFound = "Kullanıcı mevcut değil";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "token oluşturuldu";

        public static string BookNameExists = "Bookname has already exists";
        public static string BookAdded = "Book succesfully added !";

        public static string BookUpdated = "Book updated !";

        public static string BookDeleted = "Book succesfully deleted !";

        public static string CustomerAdded = "Customers succesfully added !";
    }
}
