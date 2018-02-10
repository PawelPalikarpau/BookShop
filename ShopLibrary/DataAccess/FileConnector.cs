using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLibrary.Models;
using System.IO;
using ShopLibrary.DataAccess.TextHelpers;

namespace ShopLibrary.DataAccess
{
    public class FileConnector : IFileConnection
    {
        public void CreateBoughtExcel(PersonModel person)
        {
            person.UpdateBoughtExcel();
        }

        public void CreatePerson(PersonModel person)
        {
            List<PersonModel> persons = new List<PersonModel>();
            persons.Add(person);

            persons.SaveToPersonFile();
        }

        public void UpdateLogFile(LogModel newLog)
        {
            newLog.SaveToLog();
        }
    }
}
