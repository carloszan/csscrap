using System;
using System.Collections.Generic;

namespace csscrap
{
    class ExcelOutput
    {
        public ExcelOutput()
        {
           
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


        private ClosedXML.Excel.XLWorkbook workbook;
        private List<List<string>> table;
    }
}
