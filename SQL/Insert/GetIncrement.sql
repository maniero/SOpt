INSERT INTO precoXestabelecimento (precoID, ...)
    VALUES ((SELECT last_insert_rowid()), ...);
    
--https://pt.stackoverflow.com/q/167561/101
