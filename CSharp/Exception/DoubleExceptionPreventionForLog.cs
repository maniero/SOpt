catch (Exception ex) when (!(ex is SQLException) && !(ex is EntityException)) {
    //faz o que deseja aqui
}

//melhor

catch (ex is SQLException)) {
    //faz o que deseja aqui
} catch (ex is EntityException) {
    //faz o que deseja aqui
} catch (Exception ex) {
    //faz o que deseja aqui
}

//http://pt.stackoverflow.com/q/177913/101
