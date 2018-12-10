public static int databaseFilePut(MemoryStream fileToPut) {
    int varID = 0;
    byte[] file = fileToPut.ToArray();
    const string preparedCommand = @"
                INSERT INTO [dbo].[Raporty]
                           ([RaportPlik])
                     VALUES
                           (@File)
                    SELECT [RaportID] FROM [dbo].[Raporty]
        WHERE [RaportID] = SCOPE_IDENTITY()
                ";
    using (var varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails))
    using (var sqlWrite = new SqlCommand(preparedCommand, varConnection)) {
        sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;

        using (var sqlWriteQuery = sqlWrite.ExecuteReader())
            while (sqlWriteQuery != null && sqlWriteQuery.Read()) {
                varID = sqlWriteQuery["RaportID"] is int ? (int) sqlWriteQuery["RaportID"] : 0;
            }
    }
    return varID;
}

//https://pt.stackoverflow.com/q/43713/101
