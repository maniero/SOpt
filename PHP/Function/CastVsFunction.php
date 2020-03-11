<?php
$times = 10000000;
$start_ts = microtime(true);
for ($i = 0; $i < $times; $i++) {
	$a = (int) "1";
}
echo "total = " . number_format((microtime(true) - $start_ts), 13) . " us\n";
echo "individual = " . number_format((microtime(true) - $start_ts) / $times, 13) . " us\n";
$start_ts = microtime(true);
for ($i = 0; $i < $times; $i++) {
	$a = intval("1");
}
echo "total = " . number_format((microtime(true) - $start_ts), 13) . " us\n";
echo "individual = " . number_format((microtime(true) - $start_ts) / $times, 13) . " us\n";

//https://pt.stackoverflow.com/q/147781/101
