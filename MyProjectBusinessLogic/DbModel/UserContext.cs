using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain.Entities.User;
using System.Data.Entity;

namespace MyProject.BusinessLogic.DbModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=MyProject")
        {
        }
        public virtual DbSet <UsersDbTable> Users { get; set; }
    }


}

