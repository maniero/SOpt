<?php
$clientes = array(
array(
    "nome" => "Cliente 1",
    "categoria" => "Turismo",
    "logo" => "turismo.jpg"
),
array(
    "nome" => "Suporte",
    "categoria" => "Tecnologia",
    "logo" => "suporte.jpg"
),
array(
    "nome" => "Faculdade Futura",
    "categoria" => "Educação",
    "logo" => "faculdade-futura.jpg"
));
$tmp = $clientes;
shuffle(array_slice(tmp, 15, 30));
$novo = array_merge(array_slice($clientes, 0, 15), $tmp);
foreach ($novo as $atributo => $valor):
   echo "{$valor["nome"]}\n";
endforeach;

//https://pt.stackoverflow.com/q/345270/101
