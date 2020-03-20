<?php
function teste($a) {
    $a[] = "Ola";
    $a[] = "Passei";
    $a[] = "Por";
    $a[] = "Aqui";
    return $a;
}

function teste2($a) {
    $a[] = "Também";
    $a[] = "Passei";
    $a[] = "Por";
    $a[] = "Aqui"; 
    return $a;
}
$a = Array();
$a = teste($a);
$a = teste2($a);
var_dump($a);

//https://pt.stackoverflow.com/q/440659/101
