public function busca($elemento){
    foreach ($this->arvore as $node) if($node == $elemento) return true;
    return false;
}

//https://pt.stackoverflow.com/q/388480/101
