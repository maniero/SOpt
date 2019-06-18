<?
$tag = mysqli_real_escape_string($connection,$_GET['categoria']);
$result = $connection -> query("select * from produtos where tags like '%$tag%' and online='0' order by id limit 4");
$contador = 0;
while ($contador < 4 && ($row = $result -> fetch_array(MYSQLI_ASSOC)){
    $id = $row['id'];
    $titulo = $row['titulo'];
    $resumo = $row['resumo'];
    $imagem = $row['imagem'];
?>
    <div class="row">
        <div class="grid_3">
            <div class="box2 wrap1 wow fadeInLeft" data-wow-delay="0.1s">
                <a href="verproduto.php?id=<?=$id?>"><img class="first" src="<?=$imagem?>" alt=""/></a>
                <div class="caption bggreen equal">
                    <h6 class="text_3 colorblue">
                        <a href="verproduto.php?id=<?=$id?>""><?=$titulo?></a>
                    </h6>
                    <br>
                    <p class="colorwhite">
                         <?=$resumo?>
                    </p>
                </div>
            </div>
        </div>
    </div>
<?
    $contador++;
}
$result -> free();
?>

//https://pt.stackoverflow.com/q/47532/101
