<?php
$sql = "SELECT * FROM noticias WHERE categoria='noticias' ORDER BY idnoticia DESC LIMIT 6";
$stmt = DB::prepare($sql);
$stmt->execute();
$exibe = $stmt->fetchAll();
?>
<table width="1000" align="center">
    <tr> 
      <td>&nbsp;NOTICIAS</td>
      <td>&nbsp;</td>
    </tr>
    <tr> 
      <td width="350">
          <?php
          echo "<div style='float:left;width:99%;margin-right:10px;'><a  style='color:#000;text-decoration:none;' href='{$exibe[0]->categoria}.php?idnoticia={$exibe[0]->idnoticia}'>";
          echo "<div class='thumbnail'> <img src='img/{$exibe[0]->idnoticia}/{$exibe[0]->imagem}' class='img-responsive'>";
          echo "<div class='limit'>{$exibe[0]->titulo}";
          echo "</div></div></a></div>";
          ?>
      </td>
      <td width="650">
          <?php
          $tamanho = count($exibe);
          for ($i = 1; $i < $tamanho; $i++) { 
              echo "<div style='float:left;width:99%;margin-right:10px;'><a  style='color:#000;text-decoration:none;' href='{$exibe[$i]->categoria}.php?idnoticia={$exibe[$i]->idnoticia}'>";
              echo "<div class='thumbnail'> <img src='img/{$exibe[$i]->idnoticia}/{$exibe[$i]->imagem}' class='img-responsive'>";
              echo "<div class='limit'>{$exibe[$i]->titulo}";
              echo "</div></div></a></div>";
          }
          ?>
        </td>
    </tr>
</table>

//https://pt.stackoverflow.com/q/56942/101
