SELECT *, DATE_FORMAT(date, '%m/%d/%Y') FROM tb WHERE DATE(date) < DATE_SUB(CURDATE(), INTERVAL 3 DAY)

--https://pt.stackoverflow.com/q/46946/101
