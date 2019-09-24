<?php
for ($i = 0; $i < 3; $i++) echo $i . "\n";
for ($i = 0; $i < 3; ++$i) echo $i . "\n";
$i = 0;
while ( $i < 3) { 
	echo $i . "\n";
	$i++;
}
$i = 0;
while ( $i < 3) {
	echo $i . "\n";
	++$i;
}
$i = 0;
while ( $i < 3) echo $i++ . "\n";
$i = 0;
while ( $i < 3) echo ++$i . "\n";

//https://pt.stackoverflow.com/q/80383/101
