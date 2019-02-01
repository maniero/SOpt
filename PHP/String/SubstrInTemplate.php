foreach ($exibe as $u) {
    echo "<div class='col-md-3'><div class='thumbnail'> ";
    echo "<img src='{$u->imagem}' height='120px' class='img-thumbnail'>";
    echo "<div class='caption'><h6>".substr($u->titulo, 0, 50)."</h6>";
    echo "</div></div></div>";
}

//https://pt.stackoverflow.com/q/45353/101
