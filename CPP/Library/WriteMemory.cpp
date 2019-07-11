int endereco;
scanf("%d", &endereco);
int isSuccessful = WriteProcessMemory(hproc, (LPVOID)endereco, &NewValue, (DWORD)sizeof(NewValue), NULL);

//https://pt.stackoverflow.com/q/50416/101
