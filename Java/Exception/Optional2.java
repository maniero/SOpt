Optional<User> user = findUserById("1234");
if (user.isPresent()) System.out.println("Nome do usuário = " + user.get().getName());

user.ifPresent((user) -> {
    System.out.println("Nome do usuário = " + user.getName());  
})

Optional<User> findUserById(string id) {
    var user = database.user.query(id); //pode retornar null
    return Optional.ofNullable(user);
}

//https://pt.stackoverflow.com/q/447672/101
