<?php
function &ref(&$list) {
    $return = &$list[3] ?? false;
    return $return;
}
$list = ['a', 'b', 'c', 'd', 'e'];
$elemento = &ref($list);
$elemento = 'D';
echo $list[3]; // D

//https://pt.stackoverflow.com/q/357708/101
