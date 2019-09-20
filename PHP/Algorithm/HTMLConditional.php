<?php
$vetor = array(10, 20, 30);
for ($i = 1; $i <= 50; $i++) {
    echo '<td class="'.(in_array($i, $vetor) ? 'paint_me_green' : 'paint_me_red').'"></td>';
}

//https://pt.stackoverflow.com/q/79837/101
