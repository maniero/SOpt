<?php
function a($a, $b) {
    $a1 = 0;
    $b1 = 0;
    for ($i = 0; $i < count($a); $i++) {
  		if ($a[$i] > $b[$i]) $a1++;
        if ($a[$i] < $b[$i]) $b1++;
    }
	return [$a1, $b1];
}
$a = [5, 6, 7];
$b = [3, 6, 10];
var_dump(a($a, $b));

//https://pt.stackoverflow.com/q/438915/101
