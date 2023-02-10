[System.Runtime.CompilerServices.NullableContext(1)]
[System.Runtime.CompilerServices.Nullable(0)]
public class Teste : IEquatable<Teste> {
    public int X;

    [CompilerGenerated]
    protected virtual Type EqualityContract {
        [CompilerGenerated]
        get {
            return typeof(Teste);
        }
    }

    [CompilerGenerated]
    public override string ToString() {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Teste");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder)) {
            stringBuilder.Append(' ');
        }
        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }

    [CompilerGenerated]
    protected virtual bool PrintMembers(StringBuilder builder) {
        RuntimeHelpers.EnsureSufficientExecutionStack();
        builder.Append("X = ");
        builder.Append(X.ToString());
        return true;
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    [CompilerGenerated]
    public static bool operator !=(Teste left, Teste right) {
        return !(left == right);
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    [CompilerGenerated]
    public static bool operator ==(Teste left, Teste right) {
        return (object)left == right || ((object)left != null && left.Equals(right));
    }

    [CompilerGenerated]
    public override int GetHashCode() {
        return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(X);
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    [CompilerGenerated]
    public override bool Equals(object obj) {
        return Equals(obj as Teste);
    }

    [System.Runtime.CompilerServices.NullableContext(2)]
    [CompilerGenerated]
    public virtual bool Equals(Teste other) {
        return (object)this == other || ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(X, other.X));
    }

    [CompilerGenerated]
    public virtual Teste <Clone>$() {
        return new Teste(this);
    }

    [CompilerGenerated]
    protected Teste(Teste original) {
        X = original.X;
    }

    public Teste() {}
}

namespace Microsoft.CodeAnalysis {
    [CompilerGenerated]
    [Embedded]
    internal sealed class EmbeddedAttribute : Attribute {}
}

namespace System.Runtime.CompilerServices {
    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
    internal sealed class NullableAttribute : Attribute {
        public readonly byte[] NullableFlags;

        public NullableAttribute(byte P_0) {
            byte[] array = new byte[1];
            array[0] = P_0;
            NullableFlags = array;
        }

        public NullableAttribute(byte[] P_0) {
            NullableFlags = P_0;
        }
    }

    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    internal sealed class NullableContextAttribute : Attribute {
        public readonly byte Flag;

        public NullableContextAttribute(byte P_0) {
            Flag = P_0;
        }
    }

    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
    internal sealed class RefSafetyRulesAttribute : Attribute {
        public readonly int Version;

        public RefSafetyRulesAttribute(int P_0) {
            Version = P_0;
        }
    }
}

//https://pt.stackoverflow.com/q/576780/101
