using MyProject.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;
//using MyProject.Models;

namespace MyProject.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
    }
}
