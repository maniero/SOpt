<?php
function truncate($val, $f = "0") {
    if(($p = strpos($val, '.')) !== false) {
        $val = floatval(substr($val, 0, $p + 1 + $f));
    }
    return $val;
}
echo truncate(6.3285714285714, 2);

//https://pt.stackoverflow.com/q/317767/101
