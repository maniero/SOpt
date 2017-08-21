CREATE TABLE IF NOT EXISTS `livros` (
    `codigo` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nome` VARCHAR(255) NOT NULL,
    `autor` VARCHAR(255) NOT NULL
) ENGINE = MyISAM DEFAULT CHARSET=latin1;

INSERT INTO `livros` (`nome`, `autor`) VALUES
    ('O grande Conflito', 'Ellen White'),
    ('O capital', 'Karl Marx'),
    ('O Manifesto Comunista', 'Karl Marx'),
    ('A Ideologia Alema', 'Karl Marx');
    
--https://pt.stackoverflow.com/q/230643/101
