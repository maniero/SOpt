<?php
class OutraClasse {
    public static $meu_estatico = 'variável estática';

    public static function doisPontosDuplo() {
        echo self::$meu_estatico . "\n";
    }

    public static function teste() {
        echo self::doisPontosDuplo();
    }
}

OutraClasse::teste();

//https://pt.stackoverflow.com/q/103796/101
