using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Domain.Entities.User;

namespace MyProject.BusinessLogic.Interfaces
{
	public interface IRegister
	{
		URegisterResp UserRegisterData(UsersDbTable data);
	}
}
