<?php
$arr = array(
  'id'              => '147',
  'nome'            =>'João',
  'email'           => 'joao@teste.com',
  'data_nascimento' => '05/01/1987',
  'numero_1'        => '1',
  'rua_1'           => 'rua 1', 
  'numero_2'        => '2',
  'rua_2'           => 'rua 2',
  'submit'          => 'Salvar' 
);
$newArr = array();
foreach ($arr as $k => $v) {
    $partes = explode("_", $k);
    if (count($partes) > 1) {
     	$repetido = 0;
    	foreach ($arr as $k2 => $v2) {
            if (strpos($k2, $partes[0]."_") === 0) {
                $repetido++;
            }
        }
        if ($repetido > 1)
            $newArr[$k] = $v;
    }
}
var_dump($newArr);

//https://pt.stackoverflow.com/q/40557/101
