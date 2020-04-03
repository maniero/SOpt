<?php
function m(Bar $x) {
    $x->m('Error Processing Request', 10, 1000000000);
}
class Bar {
    public function m($message, $code, $timer) {
    	echo "Bar\n";
        var_dump($message, $code, $timer);
    }
}
class Foo extends Bar {
    public function m($message) {
       echo "Foo\n";
       parent::m($message, 0, time());
    }
}
m(new Foo);

//https://pt.stackoverflow.com/q/174414/101
