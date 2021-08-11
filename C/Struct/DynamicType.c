struct data {
    int type;
    union data {
        int integer;
        double real;
        char * string;
        void * array;
        ...
    }
}

//https://pt.stackoverflow.com/q/324630/101
