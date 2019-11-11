<?php
function fibonacci($n) {
    static $cache = array();
    static $prox = 3;
    $cache[0] = 0;
    $cache[1] = 1;
    $cache[2] = 1;
    if ($n < $prox) {
    	echo "cache -> "; //está aqui só para mostrar que entrou aqui
        return $cache[$n];
    }
    for ($i = $prox; $i <= $n; $i++) $cache[$i] = $cache[$i - 1] + $cache[$i - 2];
  	echo $i - $prox . " passos -> "; //está aqui só para mostrar que entrou aqui
    $prox = $n + 1;
    return $cache[$n];
}
echo fibonacci(5) ."\n";
echo fibonacci(20) ."\n";
echo fibonacci(100) ."\n";
echo fibonacci(10) ."\n";
echo fibonacci(100) ."\n";
echo fibonacci(120) ."\n";

//https://pt.stackoverflow.com/q/104014/101
