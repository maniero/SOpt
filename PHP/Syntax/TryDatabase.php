try {
    //faz o que precisa aqui
} catch (PDOException $e){
    echo'Sistema indisponível';
    LogErros($e);
}

//https://pt.stackoverflow.com/q/39420/101
