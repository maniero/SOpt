<?php
$polylines = array(['latitude' => 73.9289238, 'longitude' => -122.29839238],
                   ['latitude' => 83.928392832, 'longitude' => 21.928918291],
                   ['latitude' => 03.293892832, 'longitude' => 30.203929832]);
foreach ($polylines as $valor) echo $valor['latitude'] . " <=> " . $valor['longitude'] . "\n";

//https://pt.stackoverflow.com/q/392407/101
