<?php
$salario = 1045;
$categoria = 'A';
switch ($categoria) {
    case 'A':
    case 'H':
        $percentagem = 10;
        break;
    case 'B':
    case 'D':
    case 'E';
        $percentagem = 15;
        break;
    case 'K':
    case 'R';
        $percentagem = 25;
        break;
    case 'X':
    case 'Z';
        $percentagem = 50;
        break;
    default:
        $percentagem = 5;
        break;
}
$salarioFinal = $salario + $salario * $porcentagem / 100;
echo "Salário atual: $salario <br/>";
echo "Salário final: R$ $salarioFinal";

//https://pt.stackoverflow.com/q/457878/101
