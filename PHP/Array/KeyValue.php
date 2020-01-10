<?php
$vetor = array(
    "Nome" => "posicao1",
    "Telefone" => "posicao2",
    "Idade" => "posicao3",
    "Sexo" => "posicao4"
 );
foreach (array_keys($vetor) as $index => $key) echo $index . ": " . $key . " => " . $vetor[$key] . "\n";

$array = array_keys($vetor);
for ($i = 0; $i <= 1; $i++) echo $array[$i] . " => " . $vetor[$array[$i]] . "\n";

//https://pt.stackoverflow.com/q/128143/101
