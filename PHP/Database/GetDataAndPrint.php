<?php 
require_once('includes/conexao.php'); //pegou dados da conexão

$sql = 'SELECT * FROM clientes'; //prepara a query a ser mandada para o banco de dados

$resultado = $con->query($sql); //executa a query e guarda o resultado em $resultado
//guarda uma linha do resultado em $clientes (este será um objeto cujos membros serão as 
//colunas da tabela clientes, será false se não tiver novas linhas)
while ($clientes = $resultado->fetch_object()) { //cada passagem aqui pega uma linha nova
    echo $clientes->nome; //pega o membro nome da linha atual que o PHP está avaliando
    echo $clientes->telefone;
} //aqui termina o processamento de uma linha e vai tentar a próxima linha no while

//https://pt.stackoverflow.com/q/51707/101
