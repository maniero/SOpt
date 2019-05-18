<?php
declare(strict_types = 1);
ini_set("display_errors", '1');
ini_set("display_startup_erros", '1');
error_reporting( E_ALL | E_STRICT | E_NOTICE ); 
function verNumero (int $num) : int {
   return $num++;
}
echo verNumero('7');
echo verNumero(7);

//https://pt.stackoverflow.com/q/384959/101
