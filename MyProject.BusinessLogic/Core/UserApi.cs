
using MyProject.Domain.Entities.User;
using MyProject.BusinessLogic.DbModel;
using System.Linq;
using System;
using System.Collections.Generic;


namespace MyProject.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data) //data = {ULoginData}
        {
            UsersDbTable result;
          
            using (var db = new UserContext())
            {
                 result = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
            };
            
            if (result==null)
            {
                return new ULoginResp { Status = false, StatusMsg = "The username or password is incorrect " };
            }
            return new ULoginResp { Status = true };
        }
    }
}
