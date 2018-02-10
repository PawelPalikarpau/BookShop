using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public CategoryModel Category { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
    }
}
