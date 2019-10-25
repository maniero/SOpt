ln = fis.read()
while ( ln != -1 ) {  
    st += (char)ln;
    ln = fis.read() //repetição de código que deveria ser canônico
}

while (true) {  
    ln = fis.read()
    if (ln != -1) break; //if horroroso
    st += (char)ln;
}

//https://pt.stackoverflow.com/q/97769/101
