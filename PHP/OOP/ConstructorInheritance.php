class Cachorro extends Animal {
    private $corPelo;

    public function __construct($nome, $idade, $corPelo) {
        parent::__construct($nome, $idade);
        $this->corPelo = $corPelo;
    }
}

//https://pt.stackoverflow.com/q/45297/101
