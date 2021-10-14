<?php
$var_1 = 8.0;
$var_2 = 4;
$var_3 = 10;
$calculo_1 = $var_1 / $var_2++;
$calculo_2 = $var_3 / $var_2++;
echo "var_1 => " . gettype($var_1) . "\n";
echo "var_2 => " . gettype($var_2) . "\n";
echo "var_3 => " . gettype($var_3) . "\n";
echo "calculo_1 => " . gettype($calculo_1) . "\n";
echo "calculo_2 => " . gettype($calculo_2) . "\n";
echo "identical => " . ($calculo_1 === $calculo_2) . "\n";
echo "equal => " . ($calculo_1 == $calculo_2) . "\n";

//https://pt.stackoverflow.com/q/530902/101
