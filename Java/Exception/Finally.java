/* package whatever; // don't place package name! */

import java.util.*;
import java.lang.*;
import java.io.*;

/* Name of the class has to be "Main" only if the class is public. */
class Ideone
{
	public static void main (String[] args) throws java.lang.Exception
	{
		System.out.println(teste());
	}
	
	public static boolean teste() {
		try {
            System.out.println("Parte 1");
            return false;
        } finally {
            System.out.println("Parte 2");
        }
	}
}

//https://pt.stackoverflow.com/q/42313/101
