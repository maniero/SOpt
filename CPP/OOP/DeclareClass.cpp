class online {};

class X {
    public:
        X();
        virtual ~X();
        X* makeMethod(string Method);
};

X* X::makeMethod(string Method) {
    return new online();
}

class online: public X {
    public:
        online();
        virtual ~online();
        void makeMethod(string Method);
};

//https://pt.stackoverflow.com/q/334925/101
