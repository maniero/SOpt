public int VerifyStatus30(List<Class.ReturnTableName> tableInfo) {
    var countDis = 0;
    using (var conn = MySqlConnection(Ambiente.ConnectionString)) { //isto estaria em uma classe estática que tem a string, mas pode por na mão
    conn.Open();
    var command = new MySqlCommand("SELECT DataObj, RecId FROM HS_REGISTRIES WHERE ErrorCode = 0 AND HandleStatus = 30 ORDER BY UpdateDate30 ASC LIMIT 1", conn);
    using (var reader = command.ExecuteReader()) {
        if (reader.HasRows) {
            countDis = 1;
            while (reader.Read()) {
                int dataObj = reader.GetInt32(0);
                int recId = reader.GetInt32(1);
                ClassTable.ReturnSapId returnSapId = new ClassTable.ReturnSapId();
                returnSapId.GetSapId(recId, dataObj, tableInfo, conn);
            }
        }
    }
    return countDis;
}

public void GetSapId(int recId, int dataObj, List<Class.ReturnTableName> tableInfo, MySqlConnection conn) {
    Class.ReturnTableName result = tableInfo.Find(x => x.IdIntegraHardness == dataObj);
    var command = new MySqlCommand("SELECT AbsEntry,u_D005_id FROM HS501_ONCM WHERE RecId = @recId", conn);
    command.Parameters.AddWithValue("@tableName", result.TableIntegraHardness.Replace("'", ""));
    command.Parameters.AddWithValue("@recId", recId);
    using (var  reader = command.ExecuteReader()) {
        if (reader.HasRows) {
            while (reader.Read()) {
                int idSAP = reader.GetInt32(0);//ID SAP
                int idHardness = reader.GetInt32(1);//ID HARDNESS
                Class.UpdateStatus updateStatus = new Class.UpdateStatus();
                updateStatus.Update40(recId, 1);
                SaveIdSH(idSAP,idHardness, tableInfo, dataObj);
                updateStatus.Update50(recId, 1);
            }
        }
    }
}

//https://pt.stackoverflow.com/q/338627/101
