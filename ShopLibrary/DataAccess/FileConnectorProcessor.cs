using OfficeOpenXml;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary.DataAccess.TextHelpers
{
    public static class FileConnectorProcessor
    {
        private const string personsfolder = "Persons";
        private const string personData = "personData.csv";
        private const string personBoughtData = "personBought.xlsx";
        private const string logData = "Log.xlsx";

        public static string FullFilePath(this string folderName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ folderName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static void SaveToPersonFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel model in models)
            {
                // id,FirstName,LastName,Password,Email,Phone,Money,RegistrationDate
                string str = $"{ model.Id },{ model.FirstName },{ model.LastName },{ model.Password },{ model.EmailAddress },{ model.PhoneNumber },{ model.Money },{ model.RegistrationDate }";
                lines.Add(str);
            }

            string personFolder = (personsfolder + $"\\" + models.First().UniqueCode).FullFilePath();
            CreateFolder(personFolder);
            string personFile = personFolder + $"\\" + personData;

            File.WriteAllLines(personFile, lines);
        }

        public static void UpdateBoughtExcel(this PersonModel person)
        {
            string personFolder = (personsfolder + $"\\" + person.UniqueCode).FullFilePath();
            CreateFolder(personFolder);
            string personBoughtFile = personFolder + $"\\" + personBoughtData;

            if (!File.Exists(personBoughtFile))
            {
                CreateBookExcel(personBoughtFile);
            }
            if (File.Exists(personBoughtFile))
            {

            }
        }
        public static void SaveToLog(this LogModel newLog)
        {
            List<LogModel> logs = GetAllLogs();
            logs.Add(newLog);

            string pathToLog = logData.FullFilePath();
            File.Delete(pathToLog);
            FileInfo fi = new FileInfo(pathToLog);

            ExcelPackage pck = new ExcelPackage(fi);
            var name = pck.Workbook.Worksheets.Add("Log");

            int logCount = 1;
            foreach (LogModel log in logs)
            {
                name.Cells["A" + logCount.ToString()].Value = log.PersonId.ToString();
                name.Cells["B" + logCount.ToString()].Value = log.FirstName;
                name.Cells["C" + logCount.ToString()].Value = log.LastName;
                name.Cells["D" + logCount.ToString()].Value = log.LogIn.ToString();
                name.Cells["E" + logCount.ToString()].Value = log.LogOut.ToString();
                logCount++;
            }

            pck.Save();
        }
        
        private static List<LogModel> GetAllLogs()
        {
            List<LogModel> logs = new List<LogModel>();

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet NwSheet;
            Microsoft.Office.Interop.Excel.Range ShtRange;
            excel = new Microsoft.Office.Interop.Excel.Application();
            
            workbook = excel.Workbooks.Open(logData.FullFilePath());

            NwSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets.get_Item(1);

            ShtRange = NwSheet.UsedRange;

            for (int Rnum = 1; Rnum <= ShtRange.Rows.Count; Rnum++)
            {
                LogModel log = new LogModel();

                log.PersonId = int.Parse(excel.Cells[Rnum, 1].Value);
                log.FirstName = excel.Cells[Rnum, 2].Value;
                log.LastName = excel.Cells[Rnum, 3].Value;
                log.LogIn = DateTime.Parse(excel.Cells[Rnum, 4].Value);
                log.LogOut = DateTime.Parse(excel.Cells[Rnum, 5].Value);

                logs.Add(log);
            }
            workbook.Close();
            excel.Quit();
            return logs;
        }
        private static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        private static void CreateBookExcel(string path)
        {
            FileInfo fi = new FileInfo(path);
            using (ExcelPackage excel = new ExcelPackage(fi))
            {
                //ExcelWorksheet worksheet = excel.Workbook.Worksheets[DateTime.Now.ToString("yyyMMdd")];
                var excelFile = excel.Workbook.Worksheets.Add("personBought");

                excelFile.Cells["A1"].Value = "Book Id";
                excelFile.Cells["B1"].Value = "Book Title";
                excelFile.Cells["C1"].Value = "Author Name";
                excelFile.Cells["D1"].Value = "Category";
                excelFile.Cells["E1"].Value = "Price";
                excelFile.Cells["F1"].Value = "Number of Pages";

                int RowNum = excelFile.Dimension.End.Row;
                int ColNum = excelFile.Dimension.End.Column;

                var headerCells = excelFile.Cells[1, 1, 1, ColNum];
                var headerFont = headerCells.Style.Font;
                var allCells = excelFile.Cells[1, 1, RowNum, ColNum];
                var border = allCells.Style.Border;

                allCells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                border.Top.Style = border.Left.Style = border.Bottom.Style = border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                headerFont.Bold = true;

                excel.Save();
            }
        }
    }
}
