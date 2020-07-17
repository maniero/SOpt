trait TestTraits {
    public function thistraitmethod($data) {
       return $data;
    }
}

class ClassUsingTrait {
    use TestTraits;
    public static function staticmethod(ClassUsingTrait $objeto, $data) {
        return $objeto->thistraitmethod($data);
    }
}

$x = new ClassUsingTrait();
ClassUsingTrait::staticmethod($x, "xxx");

//https://pt.stackoverflow.com/q/292266/101
