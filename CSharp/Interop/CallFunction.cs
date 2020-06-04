using System.Runtime.InteropServices;

public class Program {
    [DllImport("teste.DLL", EntryPoint="print")]
    static extern void print(string message);

    public static void Main(string[] args) =>print("Chamando C");
}

//Em C:

#include <stdio.h>
void print(const char *message) {
    printf("%s", message);
}

//https://pt.stackoverflow.com/q/227301/101
