class Square {
    public int side;
    public int area;
    public Square(int side) {
        this.side = side;
        area = side * side;
    }

    public static void main(String[] args) {
        Square square = new Square(5);
        System.out.println("Tamanho do lado: " + square.side + " / Area: " + square.area);
    }
}

//https://pt.stackoverflow.com/q/159602/101
