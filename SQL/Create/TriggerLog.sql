CREATE TRIGGER `empresa_AFTER_INS` AFTER INSERT ON `tabela` FOR EACH ROW
    insert into `log`.`log_tabela`(campos_do_banco, data_hora, acao, usuario)
        values (NEW.Id, NOW(), 'insert', @usuario);
        
--https://pt.stackoverflow.com/q/96674/101
