using static System.Console;
					
public class Test {
    public static void Main() {
        var sc = new SampleClass();
        IControl ctrl = (IControl)sc;
        ISurface srfc = (ISurface)sc;
        sc.Paint();
        ctrl.Paint();
        srfc.Paint();
    }
}

interface IControl {
    void Paint();
}
interface ISurface  {
    void Paint();
}
class SampleClass : IControl, ISurface {
    public void Paint() => WriteLine("Paint method in SampleClass");
    void IControl.Paint() => WriteLine("IControl.Paint");
    void ISurface.Paint() => WriteLine("ISurface.Paint");
}

//https://pt.stackoverflow.com/q/133957/101
