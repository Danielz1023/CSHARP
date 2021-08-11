using System;
using System.Collections.Generic;
using CSHARP.Collections;
namespace CSHARP.COM
{
    public class SaveToExcelUsingCOM
    {
        public void save(){
            var app = new Application { Visible = false};
            Workbook workbook = app.Workbooks.Add();
            Worksheet worksheet = app.ActiveSheet;
            int row = 1;
            foreach(var product in Product.GetSampleProducts().Where(p => p.Price != null)){
                worksheet.Cells[row,1].Value = product.Name;
                worksheet.Cells[row,1].Value = product.Price;
                row++;
            }
            workbook.SaveAs(Filename: "demo.xls", FileFormat: XlFileFormt.xlWorkbookNormal);
            app.Application.Quit();
        }
    }
}