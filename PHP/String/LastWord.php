<?php
$palavras = explode(' ', 'José da Silva');
echo $palavras[count($palavras) - 1];

$texto = ' José  da   Silva   ';
$texto = trim($texto);
echo substr($texto, strrpos($texto, ' ') + 1);

//https://pt.stackoverflow.com/q/320784/101
