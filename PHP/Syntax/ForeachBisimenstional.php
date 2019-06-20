<?php
$polylines = [  
    'latitude' => array(73.9289238, 83.928392832, 03.293892832),
    'longitude' => array(-122.29839238, 21.928918291, 30.203929832)
];
foreach ($polylines as $valor) {
    foreach ($valor as $item) echo $item . "\n";
    echo "\n";
}

//https://pt.stackoverflow.com/q/392407/101
