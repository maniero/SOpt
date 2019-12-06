<?php
$par_ou_impar = array(2, 3, 4, 56, 5, 42, 98, 100);
foreach ($par_ou_impar as $item) echo "O Número é " . ($item % 2 == 0 ? "par: " : "impar: ") . $item . "<br>";

//https://pt.stackoverflow.com/q/110925/101
