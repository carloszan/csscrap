using System;
using System.Collections.Generic;

namespace csscrap
{
    class ExcelOutput
    {
        private ClosedXML.Excel.XLWorkbook workbook;
        private List<List<string>> table;
        private List<string> list;

        public ExcelOutput(List<string> list, string book, string sheet)
        {
            this.workbook = new ClosedXML.Excel.XLWorkbook(book + ".xlsx");
            this.list = list;

            InsertIntoWorkbook(sheet);
        }

        public ExcelOutput(List<List<string>> table)
        {
            this.workbook = new ClosedXML.Excel.XLWorkbook();
            this.table = table;

            InsertIntoWorkbook();
        }
        
        public void Save()
        {   
            this.workbook.SaveAs("tabela.xlsx");
        }

        public void Save(string name)
        {
            this.workbook.SaveAs(name + ".xlsx");
        }

        private void InsertIntoWorkbook(string sheet)
        {
            var worksheet = this.workbook.Worksheet(sheet);

            int j = worksheet.LastColumnUsed().ColumnNumber() + 1;

            int i = 3;
            worksheet.Cell(2, j).Value = "Desp. Empenhadas";
            foreach (var column in this.list)
            {
                worksheet.Cell(i, j).Value = column;
                i++;
            }
        }

        private void InsertIntoWorkbook()
        {
            var worksheet = this.workbook.Worksheets.Add("Tabela");

            int i = 1, j = 1;
            foreach (var row in this.table)
            {
                foreach (var column in row)
                {
                    worksheet.Cell(i, j).Value = column;
                    j++;
                }
                i++; j = 1;
            }
        }
    }
}
