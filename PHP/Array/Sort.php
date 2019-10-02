<?php
$resultado = array();
for ($i = 0; $i <= 5; $i++) array_push($resultado, rand(1, 60));
print_r($resultado);
sort($resultado);
print_r($resultado);

//https://pt.stackoverflow.com/q/85574/101
