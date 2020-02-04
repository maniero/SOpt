#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

class Name_pairs {
public:
    void read_names();
    void read_ages(); 
    void print() const; 
    void sort(); // Ordenar os nomes com as idades        

private:
    vector<string>name;
    vector<double>age;    
};
void Name_pairs::read_names() {
    cout << "Entre com os nomes desejados, digite 'SemNome' para finalizar a lista." << endl;
    string NomesVetor; 

    while (cin >> NomesVetor && NomesVetor != "SemNome") {
        for (size_t x = 0; x < name.size(); ++x) { // confere se há nomes duplicados 
             if (name[x] == NomesVetor) cout << "Nome repetido." << endl;
        }
        name.push_back(NomesVetor);
    }
}

void Name_pairs::read_ages() {
    for (size_t x = 0; x < name.size(); ++x) {
        cout << "Nome de " << name[x] << ": " << endl;
        double IdadesVetor;
        cin >> IdadesVetor;
        age.push_back(IdadesVetor);
    }
}

void Name_pairs::print() const {
    for (size_t x = 0; x < name.size(); ++x) {
        cout << "Nome: " << name[x] << ", Idade: " << age[x] << endl;
    }
} 

void Name_pairs::sort() {
    vector<string> strCopia = name;
    vector<double> dbCopia = age; 
    std::sort(begin(name), end(name)); 
    for (size_t x = 0; x < name.size(); ++x) {
        for (size_t y = 0; y < name.size(); ++y) {
            if (name[x] == strCopia[y]) age[x] = dbCopia[y];
        }
    }
}
int main() {
    Name_pairs objeto;
    objeto.read_names();
    objeto.read_ages();
    objeto.print();
}

//https://pt.stackoverflow.com/q/138082/101
