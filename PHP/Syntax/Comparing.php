<?php
$timeZone = new DateTimeZone('UTC');
$dataInicio = new DateTime('2016-06-14', $timeZone);//dataFinal do evento
$dataFinal = new DateTime('2016-06-25', $timeZone);//dataFinal do evento
$diadasemana = "16/06";
echo $dataInicio->format('d/m') . "\n";
$cond1 = $diadasemana >= $dataInicio->format('d/m');
echo $cond1 . "\n";
echo $dataFinal->format('d/m') . "\n";
$cond2 = $diadasemana <= $dataFinal->format('d/m');
echo $cond2 . "\n";
$condFinal = $cond1 && $cond2 . "\n";
echo $condFinal . "\n";
if ($condFinal) { //e por favor, jamais coloque aqui um $condFinal == true, isto é redundante
    echo 'Entrei no IF';
} else {
    echo 'não somos igauis';
}
// Só para mostrar o problema da comparação de strings
echo "\n" . ("5/5" < "20/5" ? "Menor" : "Maior");

//https://pt.stackoverflow.com/q/135404/101
