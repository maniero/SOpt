<?php
function m(Bar $x) {
    $x->m('Error Processing Request');
}
class Bar {
    public function m($message) {
    	echo "Bar\n";
        var_dump($message);
    }
}
class Foo extends Bar {
    public function m($message, $code, $timer) {
        var_dump($code, $timer);
    	echo "Foo\n";
    	parent::m($message);
    }
}
m(new Foo);

//https://pt.stackoverflow.com/q/174414/101
