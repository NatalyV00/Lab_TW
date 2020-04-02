using MyProject.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;
using MyProject.BusinessLogic.Core;
using MyProject.BusinessLogic.Interfaces;

namespace MyProject.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

        private ULoginResp UserLoginAction(ULoginData data)
        {
            throw new NotImplementedException();
        }
    }
}
