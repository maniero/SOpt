<?php
$url = 'https://m...content-available-to-author-only...o.nz/#!4090kJrY!LZiZBgsOo_Gg1sLnykZLHsUThAC9oaPRG3---0gD92Y';
$array_url = parse_url($url);
print_r($array_url);
echo parse_url($url, PHP_URL_HOST) . "\n"; //pega o HOST
echo $array_url['host'] . "\n"; //aqui pega só o HOST também.
$dominio = explode(".", parse_url($url, PHP_URL_HOST));
echo $dominio[0];
?>

//https://pt.stackoverflow.com/q/47771/101
