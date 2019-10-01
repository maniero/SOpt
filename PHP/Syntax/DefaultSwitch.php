final class TConnection { 
    private function __construct() { }

    public static function open($name) {
        if(file_exists("../app.config/{$name}.ini")) $db = parse_ini_file("../app.config/{$name}.ini");
        else throw new Exception("Arquivo '$name' não encontrado");
        $user = $db['user'];
        $pass = $db['pass'];
        $name = $db['name'];
        $host = $db['host'];
        $type = $db['type'];
        switch($type) {
            case 'pgsql':
                $conn = new PDO("pgsql:dbname={$name};user={$user};password={$pass};host={$host}");
                break;
            case 'mysql':
                $conn = new PDO("mysql:host=".$host.";dbname={$name}",$user,$pass);
                break;
            case 'ibase':
                $conn = new PDO("firebird:dbname={$name}",$user,$pass);
                break;
            case 'mssql':
                $conn = new PDO("mssql:host={$host},1433;dbname={$name}",$user,$pass);
                break;      
            default:
                throw new PDOException('Nenhum tipo de banco de dados foi selecionado');
        }
        $conn->setAttribute(PDO::ATTR_MODE, PDO::ERRMODE_EXCEPTION);
        return $conn;
    }
}

//https://pt.stackoverflow.com/q/85515/101
