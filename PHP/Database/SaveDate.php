<?php
$_GET['birthdate'] = "2015-02-07";
$date = date("Y-m-d", strtotime($_GET['birthdate']));
echo "INSERT INTO tabela (birthday) VALUES ($date)";

//https://pt.stackoverflow.com/q/49854/101
