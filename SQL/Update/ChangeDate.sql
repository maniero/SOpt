UPDATE tbl_data SET data =
    DATE_FORMAT(STR_TO_DATE(data, '%d/%m/%Y'), '%Y-%m-%d') 
WHERE data LIKE '__/__/____'

--https://pt.stackoverflow.com/q/136742/101
