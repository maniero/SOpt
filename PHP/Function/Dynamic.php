<?php

class Produto{}
class Usuario {}
class classeExemplo
{
    public function meuMetodo($objeto)
    {
        // Seguiria aqui o bloco de código
    }
}

// Instanciando meus objetos
$produto = new Produto();
$usuario = new Usuario();

/* alimentaria meus objetos com suas respectivas informações */

// Instaciando minha classe que tem o método que recebe qualquer tipo de Objeto
$exemplo = new classeExemplo();

// Chamando o método passando objetos diferentes
$exemplo->meuMetodo($produto);
$exemplo->meuMetodo($usuario);

//https://pt.stackoverflow.com/q/100160/101
