using Dapper;
using Hangman.Components.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Hangman.Components.DataAccess.Writers
{
    public class UserWriter : WriterBase
    {
        public static void CreateUser(User user)
        {
            using (IDbConnection connection = GetConnection())
            {
                string query = "INSERT INTO HangmanDB.dbo.[User] (Name) " +
                      "VALUES(@Name);" + ReturnIdentity;
                int Id = connection.Query<int>(query, new { Name = user.Name }).Single();
                user.Id = Id;
            }
        }
    }
}