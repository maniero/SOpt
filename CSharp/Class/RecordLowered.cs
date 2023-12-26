internal class Person : IEquatable<Person>
{
    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly string <FirstName>k__BackingField;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly string <LastName>k__BackingField;

    [System.Runtime.CompilerServices.Nullable(1)]
    protected virtual Type EqualityContract
    {
        [System.Runtime.CompilerServices.NullableContext(1)]
        [CompilerGenerated]
        get
        {
            return typeof(Person);
        }
    }

    public string FirstName
    {
        [CompilerGenerated]
        get
        {
            return <FirstName>k__BackingField;
        }
        [CompilerGenerated]
        init
        {
            <FirstName>k__BackingField = value;
        }
    }

    public string LastName
    {
        [CompilerGenerated]
        get
        {
            return <LastName>k__BackingField;
        }
        [CompilerGenerated]
        init
        {
            <LastName>k__BackingField = value;
        }
    }

    public Person(string FirstName, string LastName)
    {
        <FirstName>k__BackingField = FirstName;
        <LastName>k__BackingField = LastName;
        base..ctor();
    }

    [System.Runtime.CompilerServices.NullableContext(1)]
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Person");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(" ");
        }
        stringBuilder.Append("}");
        return stringBuilder.ToString();
    }

    [System.Runtime.CompilerServices.NullableContext(1)]
    protected virtual bool PrintMembers(StringBuilder builder)
    {
        builder.Append("FirstName");
        builder.Append(" = ");
        builder.Append((object)FirstName);
        builder.Append(", ");
        builder.Append("LastName");
        builder.Append(" = ");
        builder.Append((object)LastName);
        return true;
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    public static bool operator !=(Person left, Person right)
    {
        return !(left == right);
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    public static bool operator ==(Person left, Person right)
    {
        return (object)left == right || ((object)left != null && left.Equals(right));
    }

    public override int GetHashCode()
    {
        return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(<FirstName>k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(<LastName>k__BackingField);
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    public override bool Equals(object obj)
    {
        return Equals(obj as Person);
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    public virtual bool Equals(Person other)
    {
        return (object)this == other || ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(<FirstName>k__BackingField, other.<FirstName>k__BackingField) && EqualityComparer<string>.Default.Equals(<LastName>k__BackingField, other.<LastName>k__BackingField));
    }

    [System.Runtime.CompilerServices.NullableContext(1)]
    public virtual Person <Clone>$()
    {
        return new Person(this);
    }

    protected Person([System.Runtime.CompilerServices.Nullable(1)] Person original)
    {
        <FirstName>k__BackingField = original.<FirstName>k__BackingField;
        <LastName>k__BackingField = original.<LastName>k__BackingField;
    }

    public void Deconstruct(out string FirstName, out string LastName)
    {
        FirstName = this.FirstName;
        LastName = this.LastName;
    }
}

//https://pt.stackoverflow.com/q/539114/101
