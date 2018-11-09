<?php
$numero = "5";
$decimal = "30";
echo (int)$numero + ((int)$decimal / 100.0);
echo "\n";
if (is_numeric($numero) && is_numeric($decimal)) echo (int)$numero + ((int)$decimal / 100.0);
else echo "melhor não calcular, tem erro aí";
$decimal = "a30";
echo "\n";
echo (int)$numero + ((int)$decimal / 100.0);
echo "\n";
if (is_numeric($numero) && is_numeric($decimal)) (int)$numero + ((int)$decimal / 100.0);
else echo "melhor não calcular, tem erro aí";

//https://pt.stackoverflow.com/q/342357/101
