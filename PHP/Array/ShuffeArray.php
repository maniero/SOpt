<?php
$numeros = range(0, 9);
shuffle($numeros);
$id = array_slice($numeros, 1, 9);
$mult = "";
for ($i = 0; $i < 9; $i++) {
    $mult .= $id[$i];
}
for ($i = 0; $i < 9; $i++) {
   echo $id[$i];
}

//https://pt.stackoverflow.com/q/49145/101
