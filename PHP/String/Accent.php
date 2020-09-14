<?php

function stripAccents($str) {
    return strtr(utf8_decode($str), utf8_decode(' àáâãäçèéêëìíîïñòóôõöùúûüýÿÀÁÂÃÄÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝ'), '_aaaaaceeeeiiiinooooouuuuyyAAAAACEEEEIIIINOOOOOUUUUY');
}

echo stripAccents("você está vendo o teste de acentuação");

//https://pt.stackoverflow.com/q/43636/101
