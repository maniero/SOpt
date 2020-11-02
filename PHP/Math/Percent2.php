<?php 
$produto1 = [743, 10];
$produto2 = [670, 7];
$produto3 = [560, 3];
$vendas = $produto1[1] + $produto2[1] + $produto3[1];
$receita = $produto1[0] + $produto2[0] + $produto3[0];
echo "Em outubro eu fiz ". $vendas . " vendas. <br> Minha receita foi de ". $receita. " reais. <br> <br>";
echo ($produto1[0] / $receita * 100). "<br>";
echo ($produto2[0] / $receita * 100). "<br>";
echo ($produto3[0] / $receita * 100). "<br>";

//https://pt.stackoverflow.com/q/480279/101
