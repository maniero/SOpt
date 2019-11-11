<?php
function fibonacci($n) {
    static $cache = array();
    if (isset($cache[$n])) {
    	echo "cache "; //está aqui só para mostrar que entrou aqui
        return $cache[$n];
    }
    $a = 0;
    $b = 1;
    $c = 1;
    for ($i = 1; $i < $n ; $i++) { 
        $c = $a + $b;
        $a = $b;
        $b = $c;
    }
    $cache[$n] = $c;
  	echo "calculou "; //está aqui só para mostrar que entrou aqui
    return $c;
}
echo fibonacci(100) ."\n";
echo fibonacci(10) ."\n";
echo fibonacci(100) ."\n";

//https://pt.stackoverflow.com/q/104014/101
