Class Url {
    private $url;

    public function __construct ($url) {
        if (filter_var($url, FILTER_VALIDATE_URL)) {
            $this -> url = $url;
        } else {
            $this->url= false;
        }
    }
}

//https://pt.stackoverflow.com/q/44739/101
