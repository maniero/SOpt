File home = new File(System.getProperty("user.dir"));
File file2 = new File(home, "files/meuprograma.exe");
Runtime.getRuntime().exec(file2.getPath());

//https://pt.stackoverflow.com/q/48063/101
