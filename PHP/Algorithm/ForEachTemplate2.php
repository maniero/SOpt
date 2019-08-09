<?php            
$notas = array( "Matemática" => $_POST["matematica"], "Português" => $_POST["portugues"],
                "Química" => $_POST["quimica"], "Física" => $_POST["fisica"], 
                "Geografia" => $_POST["geografia"], "História" => $_POST["historia"]);

function calculaAprovacao($nota){
    return $nota >= 60 ? "Aprovado" : "Reprovado";
}
include "cabecalho.php"
?>
<table border="1px">
<?php foreach($notas as $disciplina => $nota) { ?>
     <tr>
        <th><?php echo $disciplina; ?></th>
        <td><?php echo calculaAprovacao($nota); ?></td>
    </tr>
<?php } ?>
</table>
</body>
</html>

//https://pt.stackoverflow.com/q/53355/101
