System.getProperty("user.home")

File arquivo = new File("/dir/arquivo.ext");
Path dir = Paths.get("/dir/sub");

boolean ok = new java.io.File(System.getProperty("user.home"), "seudir").mkdirs();

//https://pt.stackoverflow.com/q/42701/101
