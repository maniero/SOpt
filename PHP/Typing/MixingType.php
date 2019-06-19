<?php
function subtracao($a, $b){
    if ($b > 0) return $a - $b;
    else return false;
}
if ($resultado = subtracao(4, 4)) echo "entrou";
else echo "não entrou";
if ($resultado = subtracao(4, 0)) echo "entrou";
else echo "não entrou";

//https://pt.stackoverflow.com/q/392182/101
