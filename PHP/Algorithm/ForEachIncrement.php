<?php
$adultos = array( "a", "b", "c" );
$i = 1;
foreach ($adultos as $adulto):
    echo "<strong>Quarto " . $i++ . "</strong><br>";
    echo "Adultos: " . $adulto . "<br>";
endforeach;

for ($i = 0; $i < count($adultos); $i++) {
    echo "<strong>Quarto ". ($i + 1) ."</strong><br>";
    echo "Adultos: " . $adultos[$i] . "<br>";
}

//https://pt.stackoverflow.com/q/238483/101
