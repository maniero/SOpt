using (DataTable dataTable = new DataTable())
using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand)) {
    mySqlDataAdapter.Fill(dataTable);
    return dataTable;
}

var dataTable = new DataTable();
using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand)) {
    mySqlDataAdapter.Fill(dataTable);
    return dataTable;
}

var dataTable = new DataTable();
try {
    using (var mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand)) {
        mySqlDataAdapter.Fill(dataTable);
        return dataTable;
    }
} finally {
    if (dataTable != null) dataTable.Dispose();
}

//https://pt.stackoverflow.com/q/101535/101
