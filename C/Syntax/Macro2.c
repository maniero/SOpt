#define MACRO(x) do { funcao(x); x++; } while (0)

if (a > 0)
    MACRO(a);
else
    a++;

#define MACRO(x) { funcao(x); x++; }

if (a > 0)
    { funcao(x); x++; };
else
    a++;

#define MACRO(x) funcao(x); x++

if (a > 0)
    funcao(x); x++;
else
    a++;
    
//https://pt.stackoverflow.com/q/80669/101
