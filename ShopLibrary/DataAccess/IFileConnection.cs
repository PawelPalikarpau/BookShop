using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ShopLibrary.DataAccess
{
    public interface IFileConnection
    {
        void CreatePerson(PersonModel person);
        void UpdateLogFile(LogModel newLog);
        void CreateBoughtExcel(PersonModel person);
    }
}
