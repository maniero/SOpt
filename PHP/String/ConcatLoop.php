<?php
$tam = 4;
$minhastring = '';
$valor = 'teste';
for ($i = 0; $i < $tam; $i++) $minhastring .= $valor . ',';
$minhastring = substr($minhastring, 0, strlen($minhastring) - 1);
echo $minhastring . "\n";
$minhastring = '';
$valor = Array('teste0', 'teste1', 'teste2', 'teste3');
$tam = sizeof($valor);
for ($i = 0; $i < $tam; $i++) $minhastring .= $valor[$i] . ',';
$minhastring = substr($minhastring, 0, -1);
echo $minhastring . "\n";
$minhastring = implode($valor, ",");
echo $minhastring;

//https://pt.stackoverflow.com/q/88228/101
