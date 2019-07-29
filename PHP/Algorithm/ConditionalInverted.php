<?php

echo $nome ?? "Tem nome";
echo $nome or "Tem nome";
echo $nome ? "Não tem nome" : $nome;
echo "\n";
$nome = "x";
echo $nome ? "Não tem nome" : $nome;

//https://pt.stackoverflow.com/q/400213/101
