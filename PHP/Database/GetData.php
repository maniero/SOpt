$dados = $mysql->query("SELECT id, titulo FROM cursos WHERE cod = 1")->fetch();
echo $dados['id'] . ' - ' . $dados['titulo'];

//https://pt.stackoverflow.com/q/274811/101
