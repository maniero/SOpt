<body>
<?php
if(isset($_POST['enviar'])){
    $nome = mysqli_real_escape_string($conexao, trim($_POST['nome']));
    $descricao = mysqli_real_escape_string($conexao, trim($_POST['descricao']));
    $detalhes = mysqli_real_escape_string($conexao, trim($_POST['detalhes']));

    $img = $_FILES['foto'];
    $name = $img['name'];
    $tmp = $img['tmp_name'];
    $size = $img['size'];
    $ext = end((explode('.', $name)));
    $pasta = '../img/produtos';
    $maxSize = 1024 * 1024 * 2;
    $permite = array('jpg','jpeg','png');

    if(empty($nome) && empty($descricao) && empty($name)){
        echo '<script>alert("Por favor, preencha o formulário de cadastro de produto corretamente.");</script>';
    }else if(empty($nome)){
        echo '<script>alert("Por favor, preencha o campo Nome.");</script>';
    }else if(empty($descricao)){
        echo '<script>alert("Por favor, preencha o campo Descrição.");</script>';
    }else if(empty($detalhes)){
        echo '<script>alert("Por favor, preencha o campo Detalhes.");</script>';
    }else if(empty($name)){
        echo '<script>alert("Por favor, selecione uma imagem.");</script>';
    }else if(!in_array($ext, $permite)){
        echo '<script>alert("A extensão da imagem selecionada não é suportada.");</script>';
    }else if($maxSize < $size){
        echo '<script>alert("A imagem selecionada é grande demais.");</script>';
    }else{
        $name = uniqid().'.'.$ext;
        $sql = mysqli_query($conexao, "INSERT INTO produtos (nome, descricao, detalhes, imagem) VALUES ('$nome', '$descricao', '$detalhes', '$name')") or die(mysqli_error($conexao));
        if($sql){
            $upload = move_uploaded_file($tmp, $pasta.'/'.$name);
            if($upload){
                echo '<script>alert("Postagem salva com sucesso!");</script>';
            }else{
                echo '<script>alert("A postagem não pôde ser salva corretamente.");</script>';
            }
        }else{
                echo '<script>alert("Desculpe, ocorreu um erro.");</script>';
            }
    }
}
?>
<div id="sendform">
<h2 class="textos" style="width:100%; text-align:center; font-weight:700">Inserir Produto</h2>
<form action="" method="post" enctype="multipart/form-data">
    <a class="textos">Nome do produto:</a><br>
    <input type="text" id="nome" name="nome" maxlength="80"><br>
    <br><a class="textos">Descrição do produto:</a><br>
    <textarea type="text" id="descricao" name="descricao"></textarea>
    <br><a class="textos">Detalhes do produto:</a><br>
    <textarea type="text" id="detalhes" name="detalhes"></textarea>
    <br><a class="textos">Selecione uma imagem para o produto.:</a><br><input type="file" id="foto" name="foto"><br>
    <input type="submit" id="enviar" name="enviar" value="Enviar">
</form>
</div>
<div id="deletar_prod">
<h2 class="textos" style="width:100%; text-align:center; margin-top:50px; font-weight:700">Deletar Produto</h2>
<?php
    if (isset($_POST['apagar']) && $_POST['apagar'] == 'excluir'){
        $deleta = mysqli_query($conexao, "DELETE FROM produtos WHERE id = '$_POST[id]'");
        if ($deleta == '1'){
        echo '<h2 class="textos" style="width:100%; text-align:center;">Produto deletado com sucesso!</h2>';
        }else{ '<h2 class="textos" style="width:100%; text-align:center;">Erro ao deletar o produto.</h2>';
    }
}
?>

<?php
    $sql = "SELECT id, nome FROM produtos ORDER BY data DESC, id DESC";
    $resultado = mysqli_query($conexao, $sql)
    or die (mysqli_error($conexao));
    if (mysqli_num_rows($resultado) == 0)
    echo '<h2 class="textos" style="width:100%; text-align:center; margin-top:0px;">Nenhum registro de produto foi encontrado.</h2>';
?>
<form id="form1" name="form1" method="post" action="" enctype="multipart/form-data">
    <select name="id" id="id">
        <option value="-1">Selecione o produto que deseja deletar</option>
<?php
    while($linha=mysqli_fetch_array($resultado)){
    $id = $linha[0];
    $nome = $linha[1];
?>
        <option value="<?php echo $id; ?>"><?php echo $nome; ?></option>
<?php
}
?>
    </select>
    <input type="hidden" name="apagar" value="excluir"/>
    <input class="botao" type="submit" name="excluir" id="excluir" value="Excluir"/>
</form>
</div>
</body>

//https://pt.stackoverflow.com/q/47880/101
