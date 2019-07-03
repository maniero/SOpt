<?php
function contador($valor){
    static $contador;
    if (isset($valor)) {
    	$contador = $valor;
    }
    return $contador;
}

echo contador(1) . "\n";
$contador = contador() + 1;
echo contador($contador);

//https://pt.stackoverflow.com/q/49521/101
