#include<string>
#include<iostream>

using std::string;
using namespace std;

class Connection {
public:
    Connection();
    string conexao;
    string getConexao();
};

Connection::Connection() {
    conexao = "sete de setembro";
}

string Connection::getConexao() {  
    cout << conexao << endl;
    return conexao;
}

int main(void) {
	Connection con;
    con.getConexao();
}

//https://pt.stackoverflow.com/q/96152/101
