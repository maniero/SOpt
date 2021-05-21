#define DUMP(varname) fprintf(stderr, "%s = %x", #varname, varname);

int i = 0;
DUMP(i); //será convertido para fprintf(stderr, "%s = %x", "i", i);

//https://pt.stackoverflow.com/q/80261/101
