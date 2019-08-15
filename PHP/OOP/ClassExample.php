class Lista { 
    private $first = null; 
    private $last = null;
    function inserirInicio($valor) { 
        $first = new No($valor, $first);
        if ($last == null) {
            $last = $first;
        }
    } 
}

//https://pt.stackoverflow.com/q/53947/101
