<?php
for ($i = 1; $i <= 300; ++$i) {
    echo $i = gmp_strval(gmp_nextprime($i + 1)) . "\n";
}

for ($i = 1; $i <= 300; $i++) {
    $cont = 0; 
    for ($j = 1; $j <= $i; $j++) {
        if($i % $j == 0) $cont++;
    }
    if ($cont == 2) print $i . "\n";
}

//https://pt.stackoverflow.com/q/53816/101
