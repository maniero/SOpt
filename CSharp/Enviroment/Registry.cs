using (RegistryKey chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true)) {
    chave.SetValue("DisallowRun", 1);
}
using (RegistryKey chave = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun", true)) {
    chave.SetValue("1", "executável que quer aqui");
}

//https://pt.stackoverflow.com/q/103625/101
