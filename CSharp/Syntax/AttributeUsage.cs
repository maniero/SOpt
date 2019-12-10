[TypeUsage(int)] //atributo hipotético
class EvenAttribute : Attribute {
    public string Message { get; set; }
    public bool IsValid(int value) {
        return value % 2 == 0;
    }
}

//https://pt.stackoverflow.com/q/119024/101
