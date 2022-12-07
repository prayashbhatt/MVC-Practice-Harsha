using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelExample.Models
{
    /// <summary>
    /// Class for storing the Product Details
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Property for storing the Product Id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Property for storing the Product Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Property for storing the Product Rate
        /// </summary>
        public double Rate { get; set; }
    }
}