using Domain.Models;
using Newtonsoft.Json;
using SageBookMvc.Controllers;

namespace SageBookMvc.Extensions
{
    public static class SessionExtensions
    {
        public static T GetObject<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default : JsonConvert.DeserializeObject<T>(sessionData) ?? default;
        }

        public static void SetObject(this ISession session, object value, string key)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static IEnumerable<Book> GetBooks(this ISession session)
        {
            return session.GetObject<List<Book>>(HomeController.ShoppingCartSessionKey) ?? new List<Book>();
        }

        public static void AddBook(this ISession session, Book book)
        {
            var currentItems = session.GetObject<List<Book>>(HomeController.ShoppingCartSessionKey) ?? new List<Book>();
            currentItems.Add(book);
            session.SetObject(currentItems, HomeController.ShoppingCartSessionKey);
        }
    }
}
