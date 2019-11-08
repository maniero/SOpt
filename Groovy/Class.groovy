class Pessoa {
    String firstName
    String lastName
    int age
    def address

    static main(args) {
      def p = new Pessoa()
      p.setFirstName("Lars")
      p.lastName = "Vogel"
      p.address = "Homestreet 3"
      def p1 = new Pessoa(firstName: "Peter", lastName:"Mueller");
      def p2 = new Pessoa(firstName: "Aline", lastName: "Gonzaga")
      println(p.firstName + " " + p.lastName);
      println ""
      println(p1.firstName + " " + p1.lastName);
      println ""
      println (p2.firstName+" "+ p2.lastName)
}

//https://pt.stackoverflow.com/q/104446/101
