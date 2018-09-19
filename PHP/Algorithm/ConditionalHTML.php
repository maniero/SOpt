while ($arrayBancas = mysql_fetch_array($oBanca->retorno())){
    echo '<div class="panel panel-default">';
    echo '  <div class="panel-heading">';
    echo '    <a href=""><center><strong>--:--</strong></center></a>';
    echo '  </div>';    
    echo '  <div class="panel-body">';    
    echo '    <h6>';
    if (date('Y-m-d', strtotime($arrayBancas['dataHora'])) == $data->format('Y-m-d')) {
        echo '      <strong>'.$arrayBancas['trabalho'].'</strong><br>';
        echo '      <strong>Orientador:</strong>'.$arrayBancas['orientador'].'<br>';   
        echo '      <strong>Banca:</strong><br>';
        echo '      <strong>Sala:</strong>'.$arrayBancas['sala'].'<br>';
    } else {
        echo '       <strong>----------</strong><br>';
        echo '       <strong>Orientador:</strong><br>'; 
        echo '       <strong>Banca:</strong><br>';
        echo '       <strong>Sala:</strong><br>';
    }
    echo '    </h6>';
    echo '  </div>';
    echo '</div>';
}

//https://pt.stackoverflow.com/q/40396/101
