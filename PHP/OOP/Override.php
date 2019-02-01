abstract class Animal {
  ...
  public function dadosAnimal() {
    return " Nome: " . $this->nome . "Idade: " . $this->idade;
  }

class Cachorro extends Animal() {
   ...
   public function dadosAnimal() {
     return parent::dadosAnimal() . " Cor do pelo: " . $this->corPelo;
}

//https://pt.stackoverflow.com/q/45348/101
