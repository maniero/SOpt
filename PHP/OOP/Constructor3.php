class Classe {
    pubclic function __construct($p1, $p2) {
        if (!isset($p2)) $p2 = 10;
        //inicialza o objeto aqui
    }
}

class Classe {
    public static function create($par) {
        return new Classe($par, 10);
    }
    pubclic function __construct($p1, $p2) {
        //inicialza o objeto aqui
    }
}

$obj = Classe::create($data);

//https://pt.stackoverflow.com/q/307092/101
