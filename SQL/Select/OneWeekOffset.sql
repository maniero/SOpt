SELECT SearchId, getdate() as CreateDate FROM Security.Search
        WHERE DATEDIFF(DAY, CreateDate, GETDATE()) < 8 AND DATEPART(DW, CreateDate) != 7
        
--https://pt.stackoverflow.com/q/55602/101
