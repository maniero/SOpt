class BoxInt {
    protected int $data;

    public function __construct(int $data) {
        $this->data = $data;
    }

    public function getData(): int {
        return $this->data;
    }
}

//https://pt.stackoverflow.com/q/135672/101
