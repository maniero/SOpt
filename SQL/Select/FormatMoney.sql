select -CAST(REPLACE(REPLACE(Valor1, '.', ''), ',', '.') AS DECIMAL(10, 2)) from TB1

select -1 * REPLACE(REPLACE(Valor1, '.', ''), ',', '.') from TB1

update TB1 set Valor1 = -1 * REPLACE(REPLACE(Valor1, '.', ''), ',', '.')

--https://pt.stackoverflow.com/q/104641/101
