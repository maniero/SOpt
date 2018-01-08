SELECT (SELECT count(*) from OBRAS) + (SELECT count(*) from TITULOS) + (SELECT count(*) from AUTORES);

#https://pt.stackoverflow.com/q/265876/101
