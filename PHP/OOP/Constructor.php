<?php
class Produto {
    private $cpu;
    private $mb;
    private $psu;
    public function __construct($cpu, $mb) {
        $this->cpu = $cpu;
        $this->mb = $mb;
    }
    function getCpu() {
        return $this->cpu;
    } 
    function setCpu($cpu) {
        $this->cpu = cpu;
    } 
    function getMb() {
        return $this->mb;
    } 
    function setMb($mb) {
        $this->mb = mb;
    } 
}

$produto = new Produto('Core i7 7700', 'Z270');
echo $produto->getCpu();
?>

//https://pt.stackoverflow.com/q/237154/101
