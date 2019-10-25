<?php
$array = array(12, 14, 121, 123);
$var = "";
foreach ($array as $item) $var .= $item . " ";
echo $var . "\n";
$array = array(12, 14, 121, 123, 12, 125, 1200);
$var = "";
foreach ($array as $item) $var .= $item . " ";
echo $var . "\n";
echo implode($array, ", ");

//https://pt.stackoverflow.com/q/96914/101
