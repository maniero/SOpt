class BoxedInt {
    int value;
    public BoxedInt(int v) { this.value = v; }
    public int Unbox() { return this.value; }
}

//Então o código:

int i = 1;
object obj = i;  
int j = (int)obj;

//seria convertido para:

int i = 1;
object obj = new BoxedInt(i);
int j = ((BoxedInt)obj).Unbox();

//http://pt.stackoverflow.com/q/16181/101
