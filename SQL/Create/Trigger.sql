CREATE TRIGGER before_insert_usuarios
    BEFORE INSERT ON usuarios
    FOR EACH ROW
    SET new.uuid = uuid();
    
--https://pt.stackoverflow.com/q/52062/101
