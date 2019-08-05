<?php 
$arrFrom = array("1","2","3","B"); 
$arrTo = array("A","B","C","D"); 
$word = "ZBB2"; 
echo str_replace($arrFrom, $arrTo, $word) . "\n"; 

$arr = array("1" => "A","2" => "B","3" => "C","B" => "D"); 
$word = "ZBB2"; 
echo strtr($word,$arr); 

//https://pt.stackoverflow.com/q/52332/101
