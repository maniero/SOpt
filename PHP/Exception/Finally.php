function addRecord($record, $db) {
    try {
      $db->lock($record->table);
      $db->prepare($record->sql);
      $db->exec($record->params);
    } catch(Exception $e) {
        $db->rollback($record);
        if (!write_log($e->getMessage(), $e->getTraceAsString())) {
            throw new Exception('Unable to write to error log.');
        }
    } finally {
        $db->unlock($record->table);
    }
    return true;
}

//https://pt.stackoverflow.com/q/48279/101
