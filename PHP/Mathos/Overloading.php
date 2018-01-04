
<?php
function parse(string $text, $callback) {
	if (gettype($callback) == "array") echo "é um array\n";
    else echo $callback;
}
parse("xxx", array("yyy"));
parse("xxx", "yyy");

//https://pt.stackoverflow.com/q/265984/101
