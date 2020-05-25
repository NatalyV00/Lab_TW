using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyProject.Domain.Entities.Products;

namespace MyProject.BusinessLogic.DbModel
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base ("name =MyProject")
        {
        }
        //no eto ne tocino ProductsData,tabel trebuie?
       // public DbSet <ProductsData> Products { get; set; }
    }
}
