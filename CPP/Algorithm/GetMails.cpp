#include <iostream>
using namespace std;

int main() {
	int op = 0;
	while (op != 5) { 
		cout << "Selecione a opção desejada\n[1] - Inserir novo nome e e-mail\n[2] - Listar e-mails\n[3] - Consultar e-mail\n";
		cout << "[4] - Deletar e-mail\n[5] - Finalizar programa\n";
		cin >> op;
	    if (op == 1) {            
	        cout << "\n\nQuantos e-mails você deseja inserir?\n";
	        int n;
	        cin >> n;
	        string nomeEmail[n][2];
	        for (int i = 0; i < n; i++) {
	            cout << "Insira o novo endereço de e-mail, e, em seguida, o nome do usuário:\n";
	            cin >> nomeEmail[i][0] >> nomeEmail[i][1];
	            cout << "Este é o e-mail de número: " << i + 1 << "\n\n";
	        }
	    }
	}
}

//https://pt.stackoverflow.com/q/420802/101
