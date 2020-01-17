<?PHP
$host = "localhost";
$user = "root";
$pass =  "";
$banco = "cadastrocli";
$conexao = mysql_connect($host,$user,$pass) or die(mysql_error());
mysql_select_db($banco) or die(mysql_error());


$idCad       = $_POST ['idCad'];
$nome       = $_POST ['Nome'];      
$email      = $_POST ['Email']; 
$senha      = $_POST ['Senha']; 
$confirmar  = $_POST ['Confirmar']; 
$telefone   = $_POST ['Telefone'];  
$celular    = $_POST ['Celular'];
$nascimento = $_POST ['Nascimento'];
$sexo       = $_POST ['Sexo'];
$bairro     = $_POST ['Bairro'];
$cidade     = $_POST ['Cidade'];
$estado     = $_POST ['Estado'];

$sql = mysql_query "(INSERT INTO cadastrocli (idCad, Nome, Email, Senha, Confirmar, Telefone, Celular, Nascimento, Sexo, Bairro, Cidade, Estado) 
VALUES ('$idCad', '$nome', '$email', '$senha', '$confirmar', '$telefone', '$celular', '$nascimento', '$sexo', '$bairro', '$cidade', '$estado');"
echo"Cadastro efetuado com sucesso;"            
?>

//https://pt.stackoverflow.com/q/133615/101
