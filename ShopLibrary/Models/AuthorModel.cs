using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Photo { get; set; }
        public List<BookModel> Books { get; set; }
        public string FullName
        {
            get
            {
                return $"{ LastName } { FirstName }";
            }
        }
    }
}
