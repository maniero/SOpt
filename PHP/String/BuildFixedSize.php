function fixedSTring($txt, $length) {
    $length = max($length, strlen($length);
    return str_pad(substr($txt, 0, $length), $length);
}

final class FixedString {
    private $txt = '';
    public function __construct($txt, $length) {
        $length = max($length, strlen($length));
        $this->txt = str_pad(substr($txt, 0, $length), $length);
    }
    public function __toString() {
        return $this->txt;
    }
}

$texto = new FixedString("teste", 20);

//https://pt.stackoverflow.com/q/77183/101
