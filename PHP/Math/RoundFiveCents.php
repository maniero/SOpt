<?php
echo round5cents(4.68) . "\n";
echo round5cents(5.22) . "\n";
echo round5cents(7.46) . "\n";

function round5cents($value) {
	return round($value / 0.05, 0) * 0.05;
}

//https://pt.stackoverflow.com/q/115577/101
