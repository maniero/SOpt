var objeto = worksheet.Row(1).Style;
objeto.Font.FontColor = ClosedXML.Excel.XLColor.White;
objeto.Font.Bold = true;
objeto.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
objeto.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

//https://pt.stackoverflow.com/q/159220/101
