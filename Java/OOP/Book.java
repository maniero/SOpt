class Book {
    private String _title;
    private String _text;

    Book(String title, String text) {
        _title = title;
        _text = text;
    }
    void NewTitle(Book livro, String newtitle) {
        livro._title = newtitle;
    }

    String BookTitle(Book livro) {
        return livro._title;
    }

    String BookText(Book livro) {
        return livro._text; 
    }

    int BookLength(Book livro) {
        return (livro._title.length() + livro._text.length());
    }

    boolean samebook(Book livro1, Book livro2){
        return (livro1._title == livro2._title && livro1._text == livro2._text);
    }
}

//https://pt.stackoverflow.com/q/89521/101
