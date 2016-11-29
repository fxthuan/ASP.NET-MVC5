using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}