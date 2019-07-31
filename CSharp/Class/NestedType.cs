public abstract class BankAccount {
    private BankAccount() {} // prevent third-party subclassing.
    private sealed class SavingsAccount : BankAccount { ... }
    private sealed class ChequingAccount : BankAccount { ... }
    public static BankAccount MakeSavingAccount() { ... }
    public static BankAccount MakeChequingAccount() { ... }
}

//https://pt.stackoverflow.com/q/51611/101
