<?php

$video = array('nome' => 'teste');
echo "<span class='video'>{$video['nome']}</span>";
echo <<<FIM
<span class='video'>{$video['nome']}</span>
FIM;
echo '<span class="video">' . $video['nome'] . '</span>';

//https://pt.stackoverflow.com/q/48185/101
