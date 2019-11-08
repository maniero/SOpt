$comment   = trim(strip_tags($_POST['comment']));
$insert = "INSERT into tb_comment (id_mark, id_user, comment, up_c, down_c, rate, active) VALUES (:post_id, :idLogged, :comment, 0, 0, :star, NOW())";
$result = $conexao->prepare($insert);
$result->bindParam(':post_id', $post_id, PDO::PARAM_INT);
$result->bindParam(':idLogged', $idLogged, PDO::PARAM_INT);
$result->bindParam(':star', $star, PDO::PARAM_INT);
$result->bindParam(':comment', $comment, PDO::PARAM_STR);
if($result->execute()){
    echo '<div class="alert alert-success" role="alert">
    <strong>Sucesso!</strong> avaliação cadastrada.
    </div>';
} else {
    echo '<div class="alert alert-danger">
    <strong>Erro ao cadastrar!</strong> Não foi possível cadastrar a avaliação.
    </div>';
}

//https://pt.stackoverflow.com/q/104081/101
