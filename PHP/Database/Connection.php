<?php

$mysqli = new mysqli("localhost","root","uma_senha_aqui");

if($mysqli-> connect_error){
    echo "Não foi possível conectar.";
}

$create_db = "CREATE DATABASE IF NOT EXISTS my_db";

if($mysqli->query($create_db)){
    echo "criação ok";
}
else{
    echo "falha na criação:" . $mysqli->error;
}

?>

//https://pt.stackoverflow.com/q/34168/101
