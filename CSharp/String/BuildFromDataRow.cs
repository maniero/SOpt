oreach (DataRow row in dt.Rows) {
    foreach (DataColumn column in dt.Columns) {
        txt += row[column.ColumnName].ToString() + ";";
    }
    txt = txt.TrimEnd(";") + "\r\n";
}

var txt = new StringBuilder(); //se tiver uma estimativa de tamanho que ela terá, coloque aqui
foreach (DataRow row in dt.Rows) {
    foreach (DataColumn column in dt.Columns) {
        txt += row[column.ColumnName].ToString() + ";";
    }
    txt = txt.Remove(txt.Length - 1, 1); + "\r\n";
}

//https://pt.stackoverflow.com/q/123213/101
