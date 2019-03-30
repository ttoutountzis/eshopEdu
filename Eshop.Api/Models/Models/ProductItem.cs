using Models.Abstruct_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class ProductItem : BaseProps
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}
