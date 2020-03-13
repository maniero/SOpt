<?php
$valor = 10000;
$percentuais = Array(0.41, 0.42, 0.43, 0.44, 0.5, 0.6);
$percentual = $valor > 80000 ? 5 : $percentuais[($valor - 1) / 5000];
echo $percentual;

//https://pt.stackoverflow.com/q/439700/101
