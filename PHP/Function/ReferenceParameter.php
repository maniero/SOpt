<?php
function something(&$string) {
    $string .= 'B';
}
$variavel = 'A';
something($variavel); //<============ Note aqui
echo $variavel; //Irá mostrar "AB"

//https://pt.stackoverflow.com/q/57741/101
