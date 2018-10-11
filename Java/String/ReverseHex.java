String s = "101c4701";
StringBuilder result = new StringBuilder();
for (int i = 0; i <=s.length()-2; i=i+2) {
    result.append(new StringBuilder(s.substring(i,i+2)).reverse());
 }
System.out.println(result.reverse().toString());

//https://pt.stackoverflow.com/q/42339/101
