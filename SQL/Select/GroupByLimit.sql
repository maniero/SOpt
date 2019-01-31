select count(id) as contagem, fruit, 
    concat(format((count(fruit) * 100 / (select count(*) from tabela)), 0), '%') as percentagem
from tabela
group by fruit desc
limit 10

--https://pt.stackoverflow.com/q/45218/101
