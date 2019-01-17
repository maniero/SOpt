CREATE TABLE `tbl_users` (
`id` int(11) NOT NULL auto_increment,
`username` varchar(250) collate latin1_general_ci NOT NULL UNIQUE KEY,
`password` varchar(250) collate latin1_general_ci NOT NULL,
PRIMARY KEY  (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci AUTO_INCREMENT=6;

--https://pt.stackoverflow.com/q/44756/101
