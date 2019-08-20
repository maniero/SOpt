class Database extends PDO {
     public function __construct() {
        parent::__construct("sqlite:" . realpath("userquestion.db"));
        $this->exec("PRAGMA foreign_keys = ON;"); // enable foreign keys
    }
}

//https://pt.stackoverflow.com/q/54474/101
