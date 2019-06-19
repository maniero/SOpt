SaveFileDialog sfd = new SaveFileDialog();

sfd.Filter = "Execl files (*.xls)|*.xls";
sfd.FileName = "teste";

if (sfd.ShowDialog() == DialogResult.OK) {
    xlApp.DisplayAlerts = false;
    xlWorkBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel12,
        Missing.Value, Missing.Value, false, false,
        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, 
        Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true,
        Missing.Value, Missing.Value, Missing.Value);
    xlWorkBook.Close(true, misValue, misValue); //isto deveria estar aqui mesmo?
}

//https://pt.stackoverflow.com/q/48274/101
