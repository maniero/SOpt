ArrayList textos = new ArrayList<String>();
textos.add("texto1");
textos.add("texto2");
String t;
for (Iterator<String> it = textos.iterator(); it.hasNext();) {
    t = it.next();
    System.out.println(t);
}

//https://pt.stackoverflow.com/q/111192/101
