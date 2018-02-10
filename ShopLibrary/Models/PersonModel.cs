using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ShopLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string UniqueCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public List<AuthorModel> BoutghtAuthors { get; set; }
        public List<AuthorModel> CartAuthors { get; set; }
        public decimal Money { get; set; }
        public byte[] Photo { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
