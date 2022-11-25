<?php
function teste(int|null valor) {
    if (valor == null) {
        echo 'sem valor';
        return;
    }
    echo valor;
}

function generateHash(HasName & HasId $item) : string {
    return sha1($item->getName() . $item->getId());
}

interface HasId {
    public function getId(): string;
}
interface HasName {
    public function getName(): string;
}

class Pessoa {
     public function getId() : string { return '1'; }
     public function getName() : string { return 'João'; }
}
generateHash(new Pessoa());

class Produto {
     public function getId() : string { return '1'; }
     public function getDescription() : string { return 'Arroz'; }
}
generateHash(new Produto());

//https://pt.stackoverflow.com/q/571198/101
