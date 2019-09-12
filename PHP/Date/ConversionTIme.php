<?php
$total = 685;
$horas = floor($total / 3600);
$minutos = floor(($total - ($horas * 3600)) / 60);
$segundos = floor($total % 60);
echo $horas . ":" . $minutos . ":" . $segundos;

//https://pt.stackoverflow.com/q/75990/101
