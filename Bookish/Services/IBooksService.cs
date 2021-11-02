using System.Collections.Generic;
using Bookish.Models.Database;
using Dapper;
using Npgsql;

namespace Bookish.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAllBooks();
    }

    public class BooksService : IBooksService
    {
        private const string ConnectionString = "Server=localhost;Port=5432;Database=bookish;Username=postgres;Password=root";

        public IEnumerable<Book> GetAllBooks()
        {
            using var connection = new NpgsqlConnection(ConnectionString);
            return connection.Query<Book>("SELECT id FROM books");
        }
    }
}