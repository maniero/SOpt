<?php
$inicio = microtime(true);
for ($i = 0; $i < 10000; $i++) {
	$var = $i;
}
echo (microtime(true) - $inicio) * 1000 . "\n";

$inicio = microtime(true);
for ($i = 0; $i < 10000; $i++) {
    $var = $i == 500 ? 0 : $i;
}
echo (microtime(true) - $inicio) * 1000 . "\n";

$inicio = microtime(true);
for ($i = 0; $i < 10000; $i++) {
	if ($i == 500) {
    	$var =  0;
	} else {
		$var = $i;
	}
}
echo (microtime(true) - $inicio) * 1000 . "\n";

//https://pt.stackoverflow.com/q/56830/101
