class Substring {
    public static void todasSubstrings(String str) {
        for (int j = str.length(); j >= 0; j--) for (int i = 0; i < j; i++) System.out.println(str.substring(i, j));
    }
    public static void main(String[] args) {
        todasSubstrings("UTFPR");
    }
}

//https://pt.stackoverflow.com/q/323222/101
