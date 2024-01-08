[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct MyPerson {
    public string first;
    public string last;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public int[] vals;
    [MarshalAs(UnmanagedType.BStr)]
    public string str;
}

[DllImport("..\\LIB\\PinvokeLib.dll", CallingConvention = CallingConvention.Cdecl)]
internal static extern int TestStructInStruct(ref MyPerson person);
[DllImport("..\\LIB\\PinvokeLib.dll", CallingConvention = CallingConvention.Cdecl)]
internal static extern int TestArrayOfStructs2([In, Out] MyPerson[] personArray, int size);

//https://pt.stackoverflow.com/q/449300/101
