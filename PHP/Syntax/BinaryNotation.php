<?php
error_reporting(E_ALL);
$string = "10100101";
$binary = (binary) $string;
var_dump($binary);
$binary = b"10100101";
var_dump($binary);

//https://pt.stackoverflow.com/q/48389/101
