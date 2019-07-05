<?php
$referenciaphp = $GET["referecia"];
$tags = get_meta_tags($referenciaphp);
$palavras=$tags['keywords'];
$individual=explode(",", $palavras);
echo $individual[0];
?>

//https://pt.stackoverflow.com/q/49859/101
