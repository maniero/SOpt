for (String f : filename) {
    String temporario[] = f.split("_");
    if (temporario.length > 1) {
        Date data = new Date(format.parse(temporario[1]).getTime());

        if (m.containsKey(temporario[0])) {
            if (m.get(temporario[0]).before(data)) {
                m.put(temporario[0], data);
            }
        } else {
            m.put(temporario[0], data);
        }
    }
}

//https://pt.stackoverflow.com/q/48379/101
