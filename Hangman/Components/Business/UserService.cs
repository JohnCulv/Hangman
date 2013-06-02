using Hangman.Components.DataAccess.Writers;
using Hangman.Components.Models;
using Hangman.Components.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Hangman.Components.Business
{
    public class UserService
    {
        public static void CreateUser(string name)
        {
            //Check to see if we have an existing name
            Components.Models.User user = UserReader.GetUserByName(name);

            if (user == null)
            {
                user = new Components.Models.User(name);
                UserWriter.CreateUser(user);
            }
            else
            {
                throw new MembershipCreateUserException(MembershipCreateStatus.DuplicateUserName);
            }
        }
    }
}