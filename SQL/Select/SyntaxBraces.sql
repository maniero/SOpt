select 
    first_name,
    coalesce(to_char(avg(p.amount),'99.99'), 'nnn') valor_medio
from
(
select 
    c.first_name as nome_cliente,
    c.last_name as sobrenome_cliente,
    to_char(avg(p.amount),'99.99') as media_valor, 
    s.first_name as nome_funcionario,
    s.last_name as sobrenome_funcionario
from 
    payment p 
    left join customer c on c.customer_id = p.customer_id
    left join staff s on s.staff_id = p.staff_id 
) as 
    tmp
    left join staff s on c.staff_id = p.staff_id
    where media_valor > 1
    
--https://pt.stackoverflow.com/q/105129/101
