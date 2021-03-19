class Program {
	public static void main (String[] args) {
		Status status = Status.ERRO;
		System.out.println(status.ordinal());
	}
}

enum Status {
    A_ENVIAR(1L), CANCELADA(2L), ERRO(3L);
    private Long numVal;
    Status(Long numVal) {
        this.numVal = numVal;
    }
}

//https://pt.stackoverflow.com/q/498152/101
