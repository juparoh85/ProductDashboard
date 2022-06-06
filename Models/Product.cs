using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductDashboard.Models
{
    public class Product
    {
        [Key]
        string data { get; set; }
    }
}