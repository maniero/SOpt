SELECT * FROM `tb_convencao` WHERE `lg_historico` = 0 AND
    `desc_database` >= MONTH(now()) - 3
    ORDER BY `desc_database` DESC

Se quiser os próximos 3 meses:

SELECT * FROM `tb_convencao` WHERE `lg_historico` = 0 AND
    `desc_database` >= MONTH(now()) AND
    `desc_database` <= MONTH(now()) + 3
    ORDER BY `desc_database` DESC

--https://pt.stackoverflow.com/q/82510/101
