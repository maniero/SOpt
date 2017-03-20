using System;
using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var dict = new Dictionary<Class1, int> { { new Class1 { Id = new Guid(), Name = "João" }, 0 }};
		foreach (var item in dict) {
			WriteLine(item.Key.Name);
		}
	}
}

public class Class1 : IEquatable<Class1> {
    public Guid Id { get; set; }
    public string Name { get; set; }

    public bool Equals(Class1 other) {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id.Equals(other.Id) && string.Equals(Name, other.Name);
    }

    public override bool Equals(object obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Class1) obj);
    }

    public override int GetHashCode() {
        unchecked {
            int hash = (int) 2166136261;
            hash = (hash * 16777619) ^ Id.GetHashCode();
            return hash = (hash * 16777619) ^ (Name != null ? Name.GetHashCode() : 0);
        }
    }

    public static bool operator ==(Class1 left, Class1 right) {
        return Equals(left, right);
    }

    public static bool operator !=(Class1 left, Class1 right) {
        return !Equals(left, right);
    }
}

//http://pt.stackoverflow.com/q/191257/101
