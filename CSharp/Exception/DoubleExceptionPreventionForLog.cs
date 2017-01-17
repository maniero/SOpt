catch (Exception ex) when (!(ex is DbException) && !(ex is EntityException)) {
    //faz o que deseja aqui
}

//melhor capturar as específicas antes

catch (ex is DbException)) {
    //faz o que deseja aqui
} catch (ex is EntityException) {
    //faz o que deseja aqui
} catch (Exception ex) {
    //faz o que deseja aqui
}

//http://pt.stackoverflow.com/q/177913/101
