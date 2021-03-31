int main() {
    while (1) {
        char str;
        cout << "selecione a opcao do objeto 1:";
        cin >> ob1;
        cout << "selecione a opcao do objeto 2:";
        cin >> ob2;
        int apc *obj1 = new apc(ob1);
        int apc *obj2 = new apc(ob2);
        cout << obj1->getPublicInt() << "\n";
        cout << obj1->getPublicStrings() << "\n";
        cout << obj2->getPublicInt() << "\n";
        cout << obj2->getPublicStrings() << "\n";
        while (1) {
            cout << "continuar ? s ou n" << "\n";
            cin >> str;
            if (str == 's' || str == 'S') break;
            if (str == 'n' || str == 'N') {
                system("pause");
                return 0;
            } else cout << "opcao invalida!";
        }
    }
}

//https://pt.stackoverflow.com/q/488010/101
