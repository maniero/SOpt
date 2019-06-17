<?php

$_UP['extensoes'] = array('docx', 'xlsx', 'pdf', 'jpg', 'png', 'gif', 'jpeg' );
$extensao = @strtolower(end(explode('.', "nome.doc")));
if (array_search($extensao, $_UP['extensoes']) === false) {
   echo "Por favor, envie arquivos com as seguintes extensões: jpg, png ou gif";
}
$extensao = @strtolower(end(explode('.', "nome.docx")));
if (array_search($extensao, $_UP['extensoes']) === false) {
   echo "Por favor, envie arquivos com as seguintes extensões: jpg, png ou gif";
}

//https://pt.stackoverflow.com/q/47403/101
