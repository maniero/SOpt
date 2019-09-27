CSimpleIniA ini;
ini.SetUnicode();
ini.LoadFile("arquivos.ini");
const char * pVal = ini.GetValue("config", "host", NULL);
ini.SetValue("config", "host", "127.0.0.1");

//https://pt.stackoverflow.com/q/83599/101
