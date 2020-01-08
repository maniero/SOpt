SET @tipo    = 47;
SET @dataini = '2016-03-17';
SET @datafin = '2016-03-18';
    SELECT 
      * 
       FROM sale 
            WHERE  start_time BETWEEN @dataini AND @datafin 
               AND sale_type = @tipo
               
--https://pt.stackoverflow.com/q/126839/101
