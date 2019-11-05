void PopulaGrid(DataGridView grid, SQLiteDataReader dados) {
    grid.Rows.Clear();
    grid.Columns.Clear();
    for (int i = 1; i < dados.FieldCount; i++) { // <========================== mudei aqui
        DataGridViewColumn coluna = new DataGridViewTextBoxColumn();
        coluna.HeaderText = dados.GetName(i);
        coluna.Visible = true;
        coluna.Name = "coluna" + 1;
        coluna.Resizable = DataGridViewTriState.True;
        grid.Columns.Add(coluna);
    }
    while (dados.Read()) {
        object[] campos = new object[dados.FieldCount];
        for (int i = 1; i < dados.FieldCount; i++) // <========================= mudei aqui
            campos[i] = dados.GetValue(i);
        grid.Rows.Add(campos);
    }
}

//https://pt.stackoverflow.com/q/103581/101
