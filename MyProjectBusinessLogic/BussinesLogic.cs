using MyProject.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
//using MyProject.BusinessLogic.Interfaces;

namespace MyProject.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

        public IRegister GetRegisterBL()
        {
            return new UserRegisterBL();
        }
    }
}
