<?php
function dtLength($sec) {
    $t=new DateTime("@".$sec);
    $r=new DateTime("@0");
    $i=$t->diff($r);
    $h=intval($i->format("%a"))*24+intval($i->format("%H"));
    return $h.":".$i->format("%I:%S");
}

$date = new DateTime;
$tempo_1 =  10 * 3600; // 10 horas
$tempo_2 = 18 * 3600; // 18 horas
$tempo_3 = 28 * 3600; // 28 horas
echo $date->setTime(0, 0, $tempo_1)->format('H:i:s'); // 10:00:00
echo $date->setTime(0, 0, $tempo_2)->format('H:i:s'); // 18:00:00
echo $date->setTime(0, 0, $tempo_3)->format('H:i:s'); // 04:00:00
echo dtLength($tempo_1);
echo dtLength($tempo_2);
echo dtLength($tempo_3);

//https://pt.stackoverflow.com/q/51821/101
