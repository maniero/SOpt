CREATE TABLE andares (andar int(1));

INSERT INTO andares (andar) VALUES (1), (2), (3), (1), (2), (1);

SELECT andar, COUNT(*) AS quantidade FROM andares GROUP BY andar;

--https://pt.stackoverflow.com/q/446790/101
