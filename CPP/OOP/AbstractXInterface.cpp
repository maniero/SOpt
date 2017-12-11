class Mother {
    string test01;
    int test03;
    public:
        virtual string getTest01();
        virtual void setTest01(string teste01);
        virtual int getTest03();
        virtual void setTest03(int teste03);
};

string Mother::getTest01() { return test01; }
void Mother::setTest01(string test01) { this.test01 = test01; }
int Mother::getTest03() { return test03; }
void Mother::setTest03(int test03) { this.test03 = test03; }

//Daughter.h

class Daughter: virtual public Mother {}; //só faz sentido se fizer mais alguma coisa

//Interface

class Mother {
    public:
        virtual string getTest01() = 0;
        virtual void setTest01(string teste01) = 0;
        virtual int getTest03() = 0;
        virtual void setTest03(int teste03) = 0;
};

//Daughter.h

class Daughter: virtual public Mother {}; //não muito, mas aqui até faz sentido

string Daughter::getTest01() { return test01; }
void Daughter::setTest01(string test01) { this.test01 = test01; }
int Daughter::getTest03() { return test03; }
void Daughter::setTest03(int test03) { this.test03 = test03; }

//https://pt.stackoverflow.com/q/258236/101
