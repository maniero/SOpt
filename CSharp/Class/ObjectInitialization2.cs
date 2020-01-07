using static System.Console;
public class Program {
	public static void Main() {
		string StudentName;
		Student stud = new Student(StudentName = "New Student");
		WriteLine(StudentName);
	}
}

class Student {
	private string name;
	public Student(string nome) => name = nome;
}

//https://pt.stackoverflow.com/q/126348/101
