<?php
$array_banco = array(array('field' => 'data', 'description' => 'Data cadastro'),
                     array('field' => 'ndereco', 'description' => 'Endereco')
);
foreach($array_banco as $item){
    $fields[$item['field']] = $item['description'];
}
var_dump($fields);

//https://pt.stackoverflow.com/q/45323/101
