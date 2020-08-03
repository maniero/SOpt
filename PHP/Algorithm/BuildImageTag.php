if ($formaCombate == "patk") {
    if($patk1 > $patk2) echo "<a href = 'jogador1ganhou.html'><img src = 'venceu1.png'/></a>";
    elseif ($patk1 < $patk2) echo "<a href = 'jogador2ganhou.html'><img src = 'venceu2.png'/></a>";
    else echo "<a href = 'empatou.html'><img src = 'empat1.png'/></a>";
}

//https://pt.stackoverflow.com/q/325112/101
