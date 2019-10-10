<?php
$arquivos = glob('/*.*');
if (!$arquivos) echo count($arquivos);
else echo 'houve um erro';

//https://pt.stackoverflow.com/q/88450/101
