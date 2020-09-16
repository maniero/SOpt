<?php

echo filter_var("1--1--+--1", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1", FILTER_VALIDATE_INT), ".\n";
echo filter_var("-1", FILTER_VALIDATE_INT), ".\n";
echo filter_var("+1", FILTER_VALIDATE_INT), ".\n";
echo filter_var("a1", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1a", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1.2", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1.0", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1+1", FILTER_VALIDATE_INT), ".\n";
echo filter_var(" 1", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1 ", FILTER_VALIDATE_INT), ".\n";
echo filter_var("01", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1111111111111111111111111111", FILTER_VALIDATE_INT), ".\n";
echo filter_var("1 1", FILTER_VALIDATE_INT), ".\n";

//https://pt.stackoverflow.com/q/47093/101
