CREATE TABLE `data_tracking` (
`tracking_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
`data_id` INT NOT NULL ,
`field` VARCHAR( 50 ) NOT NULL ,
`old_value` INT NOT NULL ,
`new_value` INT NOT NULL ,
`modified` DATETIME NOT NULL
) ENGINE = MYISAM ;

DELIMITER $$

DROP TRIGGER `update_data `$$

CREATE TRIGGER `update_data` AFTER UPDATE on `data_table`
FOR EACH ROW
BEGIN
    IF (NEW.field1 != OLD.field1) THEN
        INSERT INTO data_tracking 
            (`data_id` , `field` , `old_value` , `new_value` , `modified` ) 
        VALUES 
            (NEW.data_id, "field1", OLD.field1, NEW.field1, NOW());
    END IF;
    IF (NEW.field2 != OLD.field2) THEN
        INSERT INTO data_tracking 
            (`data_id` , `field` , `old_value` , `new_value` , `modified` ) 
        VALUES 
            (NEW.data_id, "field2", OLD.field2, NEW.field2, NOW());
    END IF;
    IF (NEW.field3 != OLD.field3) THEN
        INSERT INTO data_tracking 
            (`data_id` , `field` , `old_value` , `new_value` , `modified` ) 
        VALUES 
            (NEW.data_id, "field3", OLD.field3, NEW.field3, NOW());
    END IF;
END$$

DELIMITER ;

--https://pt.stackoverflow.com/q/83883/101
