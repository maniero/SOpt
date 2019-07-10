function teste($resultadowhile) {
    $resultadowhile .= "<table class='table table-hover'><thead><tr><th>Cod.</th><Data</th><th>Última Atualização</th><th>Unidade</th><th>Departamento</th><th>Arquivo</th><th>Status</th></tr>";
    while($row = mysql_fetch_array($result)){
        $resultadowhile .= "<tr>" . 
            '<td>s<a href="cadastro_arquivo.php?id=' . $row['id_arquivo'] . '">' . $row['id_arquivo'] . '</a></td>' . 
            '<td>' . formatarDataBRASIL($row['txt_data']) . '</td>' . 
            '<td>' . $row['txt_unidade'] . '</td>' . 
            '<td>' . $row['txt_departamento'] . '</td>' . 
            '<td>' . $row['txt_arquivo'] . '</td>' . 
            '<td>' . $row['flag_status'] . '</td>' . 
        "</tr>";
    }
    $resultadowhile .= "</table>";
    return $resultadowhile;
}

function PageLoad_Arquivo() {
    $result = mysql_query("
    select a.id_arquivo, a.txt_arquivo, a.txt_data, a.txt_caminho, d.id_departamento, d.txt_departamento, u.id_unidade, u.txt_unidade, a.flag_status from tb_arquivo a
    left join tb_departamento d on a.id_departamento = d.id_departamento
    left join tb_unidade u on a.id_unidade = u.id_unidade
    ORDER BY a.txt_data DESC
    ") or die(mysql_error());
    $relacao = "style='display:block'";
    $cadastro = "style='display:none'";
    $resultadowhile = "";
    if(mysql_num_rows($result) > 0){
        $resultadowhile = teste($resultadowhile);
        renderForm('', '', '', '', '', '', '', '', $relacao, $cadastro, $resultadowhile);
    }else{
        $resultadowhile = "<div class=\"alert alert-warning\" role=\"alert\">Sem resultados.</div>";
        renderForm('', '', '', '', '', '', '', '', $relacao, $cadastro, $resultadowhile);
    }
}

//https://pt.stackoverflow.com/q/50371/101
