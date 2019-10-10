UPDATE tabela SET datanova = STR_TO_DATE(data, '%d-%m-%Y')

SELECT * FROM tabela WHERE STR_TO_DATE(data, '%d-%m-%Y')
                           BETWEEN '2015/08/15' AND '2015/08/25'
                               
--https://pt.stackoverflow.com/q/89244/101
