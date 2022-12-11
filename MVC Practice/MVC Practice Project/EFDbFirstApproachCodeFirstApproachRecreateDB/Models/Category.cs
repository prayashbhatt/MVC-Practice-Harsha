using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFDbFirstApproachCodeFirstApproachRecreateDB.Models
{
    public class Category
    {
        [Key]
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}