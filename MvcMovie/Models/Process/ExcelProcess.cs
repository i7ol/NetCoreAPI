using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace MvcMovie.Models.Process
{
    public class ExcelProcess
    {
        public List<Person> ExcelToList(string filePath)
        {
            var peopleList = new List<Person>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    var person = new Person
                    {
                        PersonId = worksheet.Cells[row, 1].Text,
                        FullName = worksheet.Cells[row, 2].Text,
                        Age = int.TryParse(worksheet.Cells[row, 3].Text, out int age) ? age : 0
                    };
                    peopleList.Add(person);
                }
            }

            return peopleList;
        }
    }
}
