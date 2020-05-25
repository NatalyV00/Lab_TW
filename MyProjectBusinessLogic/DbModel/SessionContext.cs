using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain.Entities.User;

namespace MyProject.BusinessLogic.DbModel
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name=MyProjectDb")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}
