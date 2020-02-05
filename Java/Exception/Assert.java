try {
    executarAcao();
} catch (Exception e) {
    assertThat(e).isInstanceOf(IllegalStateException.class)
                 .hasMessage("Falhou devido à condição 1");
}

//https://pt.stackoverflow.com/q/138468/101
