class Person {
    String fname = "f";
    String lname = "Doe";
    int age = 24;

    public static String mudaNome(String nome) {
        if (!nome.equals("fiii")) nome = mudaNome(nome + "i");
        return nome;
    }

    public static Person mudaNomeObj(Person myObj) {
        if (!myObj.fname.equals("fiii")) {
            myObj.fname += "i";
            mudaNomeObj(myObj);
        }
        return myObj;
    }

	public static void main(String[] args) {
	   Person myObj = new Person();
	   System.out.println("name1 final output: " + mudaNome(myObj.fname));
	   System.out.println("---------------");
	   Person myObj2 = new Person();
	   System.out.println("name2 final output: " + mudaNomeObj(myObj2).fname);
	}
}

//https://pt.stackoverflow.com/q/419019/101
