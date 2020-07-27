UPDATE produto SET codigo = to_char(to_number(codigo, '999999') + 1);

--https://pt.stackoverflow.com/q/318232/101
