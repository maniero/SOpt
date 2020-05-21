class Main {
	public static void main( String[] args ) {
	    ABC obj = new XYZ();
	    System.out.println(((XYZ) obj).getXYZ());
	}
}

class  ABC  { 
    int x = 0;   
    public int getABC() {  
        return x;
    }  
}

class XYZ extends ABC  { 
    int y = 0;   
    public int getXYZ() {  
        return y;
    }  
}

//https://pt.stackoverflow.com/q/453005/101
