using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.BusinessLogic.Core;
using MyProject.BusinessLogic.Interfaces;
using MyProject.Domain.Entities.User;

namespace MyProject.BusinessLogic
{
	class UserRegisterBL : UserApi, IRegister
	{
		public URegisterResp UserRegisterData(UsersDbTable data)
		{
			return UserRegisterAction(data);
		}

	}
}