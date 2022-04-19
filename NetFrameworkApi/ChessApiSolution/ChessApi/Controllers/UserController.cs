using DataManager.Library.DataAccess;
using DataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ChessApi.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        // GET: User
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId);
        }


        // Probably going to want a user edit. 
        // There isn't anything by default

        // This is handled in the EF DB. 
        //public void AddUser(UserModel newUser)
        //{
        //    UserData data = new UserData();
        //    data.CreateUser(newUser);

        //}
    }
}
