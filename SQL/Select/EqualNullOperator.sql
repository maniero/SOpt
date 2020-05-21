SELECT 1 <=> 1, NULL <=> NULL, 1 <=> NULL;
        -> 1, 1, 0
SELECT 1 = 1, NULL = NULL, 1 = NULL;
        -> 1, NULL, NULL
        
--https://pt.stackoverflow.com/q/211813/101
