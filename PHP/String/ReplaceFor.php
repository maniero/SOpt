<?php
$string = "O João foi ao Hotel & Spa passar férias";
$stringCorrigida = "";
$stringLength = strlen($string);
for ($i = 0; $i < $stringLength; $i++) $stringCorrigida .= ($string[$i] == '&' ? 'e' : $string[$i]);
echo $stringCorrigida;

//https://pt.stackoverflow.com/q/17077/101
