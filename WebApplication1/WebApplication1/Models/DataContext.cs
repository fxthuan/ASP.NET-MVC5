using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DataContext : DbContext
    {
        public System.Data.Entity.DbSet<WebApplication1.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Product> Products { get; set; }
    }
}