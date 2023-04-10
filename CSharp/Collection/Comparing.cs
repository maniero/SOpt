using static System.Console;
using System.Collections.Generic;
                    
var roberto = new User("Roberto", 45);
List<User> users = new () {
	new User("Fernando", 23),
	new User("Roberto", 45),
	roberto
};
var alessandra = new User("Alessandra", 27);
foreach(User u in users) WriteLine($"Nome='{u.Name}' Idade={u.Age}");
WriteLine($"Coleção contém alessandra? {users.Contains(alessandra)}");
users.Add(alessandra);
WriteLine($"Coleção contém alessandra? {users.Contains(alessandra)}");
WriteLine($"Conseguiu remover roberto da variável? {users.Remove(roberto)}");
WriteLine($"Coleção contém roberto? {users.Contains(roberto)}");
foreach(User u in users) WriteLine($"Nome='{u.Name}' Idade={u.Age}");
WriteLine($"Conseguiu remover roberto da variável? {users.Remove(roberto)}");

public class User {
    public string Name {get;set;}
    public int Age {get;set;}
    
    public User(string name, int age) { Name = name; Age = age; } 
}

//https://pt.stackoverflow.com/q/581105/101
