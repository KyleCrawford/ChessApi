using DataManager.Library.Internal.DataAccess;
using DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Library.DataAccess
{
    public class UserData
    {
        // functions needed:
            // get logged in user
            // update info
            // delete account
            // create? Going to need it, don't know how this is going to work just yet
            // this somehow needs to get called when the user creates the account with MS Identity 

        public UserModel GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Id = id };
            var output = sql.LoadData<UserModel, dynamic>("dbo.spGetUser", p, "ChessConn");
            return output.First();
        }
    }
}
