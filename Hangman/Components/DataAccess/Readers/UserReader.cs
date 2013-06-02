using Dapper;
using Hangman.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Hangman.Components.DataAccess;

namespace Hangman.Components.Readers
{
    public class UserReader : ConnectionBase
    {
        public static User GetUserByName(string name)
        {
            using (IDbConnection connection = GetConnection())
            {
                const string query = "SELECT Id, Name " +
                      "FROM HangmanDB.dbo.[User] " +
                      "WHERE Name = @Name";
                return connection.Query<User>(query, new { Name = name }).FirstOrDefault();
            }

        }
    }
}