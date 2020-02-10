class Router {
    private static $name;

    public static function get() {
        return $this;
    }

    public function name($name) {
        self::$name = $name;
    }
}

//https://pt.stackoverflow.com/q/434659/101
