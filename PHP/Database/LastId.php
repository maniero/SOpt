$ultimoID = $db->lastInsertId();
if ($ultimoID) {
    mkdir("../imagens/" . $ultimoID); //talvez precise colocar permissões mas resolve a dúvida principal
    setMessage("Notícia cadastrado com sucesso.");
    redirect("noticiasListar.php");
}

//https://pt.stackoverflow.com/q/45676/101
