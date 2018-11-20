<?php
$a = (object)["a" => "b"];
$b = (object)["a"  => "c"];
$y = $a <=> $b;
echo $y;
$v=[1,2,3] <=> [1,2,3];
echo $v;
$a= (object)["a" => "b"];
$b = (object)["a" => "b"];
echo $a <=> $b;
echo ($y == -1)? 1:0;
var_dump($a);

//https://pt.stackoverflow.com/q/343530/101
