<?php
class ConnectDB {
    public $pdo;
    private $driver, $host, $port, $base, $user, $pass;

    public function __construct() {
        $this->setDriver('mysql');
        $this->setHost('localhost');
        $this->setPort('3306');
        $this->setBase('bsn');
        $this->setUser('root');
        $this->setPass('');
        $this->connect();
    }

    public function connect() {
        try {
            $this->pdo = new PDO("{$this->getDriver()}:host={$this->getHost()};port={$this->getPort()};dbname={$this->getBase()}", $this->getUser(), $this->getPass());
            $this->pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $this->pdo->setAttribute(PDO::ATTR_CASE, PDO::CASE_NATURAL);
        } catch (PDOException $e) {
            die('Ocorreu um erro na conexão com o banco de dados.');
        }
    }

    public function setDriver($str) {
        $this->driver = $str;
    }

    public function setHost($str) {
        $this->host = $str;
    }

    public function setPort($str)   {
        $this->port = $str;
    }

    public function setBase($str)   {
        $this->base = $str;
    }

    public function setUser($str)   {
        $this->user = $str;
    }

    public function setPass($str)   {
        $this->pass = $str;
    }

    public function getPDO()    {
        return $this->pdo;
    }

    public function getDriver() {
        return $this->driver;
    }

    public function getHost() {
        return $this->host;
    }

    public function getPort() {
        return $this->port;
    }

    public function getBase() {
        return $this->base;
    }

    public function getUser() {
        return $this->user;
    }

    public function getPass() {
        return $this->pass;
    }
}

class ManipulateData extends ConnectDB {
    public function select($query) {
        $stmt = $this->getPDO()->prepare($query);
        $stmt->execute();
        return $stmt->fetchAll();
    }
}
$obj = new ManipulateData();
print_r(obj.select('SELECT * FROM vagas'));

//https://pt.stackoverflow.com/q/331916/101
