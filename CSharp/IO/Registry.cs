const string REG_KEY_NAME = @"SOFTWARE\Bar\Baz";
using (RegistryKey key = Registry.CurrentUser.OpenSubKey(REG_KEY_NAME, false)) // Abrir a key para leitura
{
    string Valor = key.GetValue("NomeDoValor").ToString();
}

using (RegistryKey key = Registry.CurrentUser.OpenSubKey(REG_KEY_NAME, true)) // Abrir a key para leitura/gravação
{
    key.SetValue("NomeDoValor", "FooBar");
}

//https://pt.stackoverflow.com/q/47287/101
