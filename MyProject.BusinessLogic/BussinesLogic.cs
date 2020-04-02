using MyProject.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        { 
            return new SessionBL();
        }
    }
}
