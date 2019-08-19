<?php
$meses = 3;
$valor = 1000;
$boletos = [];
for ($i = 1; $i <= $meses; $i++) array_push($boletos, round($valor / $meses, 0));
$boletos[$meses - 1] += $valor - array_sum($boletos);
print_r($boletos);

//https://pt.stackoverflow.com/q/403984/101
