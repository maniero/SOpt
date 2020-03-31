SELECT * FROM sqlite_master WHERE type='table';

ATTACH novoBanco.db AS novo;

SELECT * FROM novo.sqlite_master WHERE type='table';

--https://pt.stackoverflow.com/q/171687/101
