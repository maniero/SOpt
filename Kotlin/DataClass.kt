data class User(val name: String, val age: Int)

public class User {
    private String name;
    private int age;

    public User() {
        this.name = "";
        this.age = 0;
    }

    public User(String name) {
        this.name = name;
        this.age = 0;
    }

    public User(int age) {
        this.name = "";
        this.age = age;
    }

    public User(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    public String component1() { //para acesso posicional e deconstrução
        return name;
    }

    public int component2() {
        return age;
    }

    public User copy() {
        return new User(name, age);
    }

    public User copy(String newName) {
        return new User(newName, age);
    }

    public User copy(int newAge) {
        return new User(name, newAge);
    }

    public User copy(String newName, int newAge) {
        return new User(newName, newAge);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        User user = (User) o;

        if (age != user.age) return false;
        return name != null ? name.equals(user.name) : user.name == null;
    }

    @Override
    public int hashCode() {
        int result = name != null ? name.hashCode() : 0;
        result = 31 * result + age;
        return result;
    }

    @Override
    public String toString() {
        return "User{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }
}

//https://pt.stackoverflow.com/q/228422/101
