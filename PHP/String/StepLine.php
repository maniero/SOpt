<?php
$texto = "Medidas dos produtos da(s) foto(s) (cm): - 3 Lugares + Chaise: -   Largura: 281 -   Profundidade: 161 -   Altura: 94 - 3 Lugares: -   Largura: 225 -   Profundidade: 94 -   Altura: 94 - 2 Lugares: -   Largura: 170 -   Profundidade: 94 -   Altura: 94 - Modulado 2 Lugares + Canto + 3 Lugares: -   Largura (2 Lugares + Canto): 246 -   Largura (3 Lugares + Canto): 301 -   Profundidade: 94 -   Altura: 94 - Opções de tamanho: -   1 Lugar -   2 Lugares -   3 Lugares -   Modulado (assento, chaise e canto). -   Modelo também possui opção de puff. - Revestimento: -   Várias opções em tecido e couro sintético.";
do {
    $posicao = strpos($texto, "-", 1);
    $linhaQuebrada .= ($posicao ? substr($texto, 0, $posicao) : $texto) . "\r\n";
    $texto = substr($texto, $posicao);
} while ($posicao);
echo $linhaQuebrada;

//https://pt.stackoverflow.com/q/49912/101
