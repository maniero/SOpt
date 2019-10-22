class Casa {
    private String parede;
    public void setParede(String parede) {
        this.parede = parede;
    }
    public String getParede() {
        return parede;
    }
}

class Main {
    public static void main(String[] args) {
        String erro="";
        try {
            Casa casa = new Casa();
            casa.setParede("Parede Sul");
            System.out.println(casa.getParede());
        } catch (Exception e) {
            erro = e.getMessage();
        } finally {
            System.out.println(erro);
        }
    }
}

//https://pt.stackoverflow.com/q/92535/101
