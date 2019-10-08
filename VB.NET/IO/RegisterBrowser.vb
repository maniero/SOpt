Registry.ClassesRoot.OpenSubKey(@".htm", true).SetValue("", "FirefoxHTML");
Registry.ClassesRoot.OpenSubKey(@".html", true).SetValue("", "FirefoxHTML");
Registry.ClassesRoot.OpenSubKey(@".shtml", true).SetValue("", "FirefoxHTML");
Registry.ClassesRoot.OpenSubKey(@".xht", true).SetValue("", "FirefoxHTML");
Registry.ClassesRoot.OpenSubKey(@".xhtml", true).SetValue("", "FirefoxHTML");
Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command", true).SetValue("", "firefox.exe");
Registry.ClassesRoot.OpenSubKey(@"https\shell\open\command", true).SetValue("", "firefox.exe");
Registry.CurrentUser.OpenSubKey(@"Software\Classes\http\shell\open\command", true).SetValue("", "firefox.exe");
Registry.CurrentUser.OpenSubKey(@"Software\Classes\https\shell\open\command", true).SetValue("", "firefox.exe");
Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice", true).SetValue("progId", "FirefoxURL");
Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice", true).SetValue("progId", "FirefoxURL");
Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\ftp\UserChoice", true).SetValue("progId", "FirefoxURL");

'https://pt.stackoverflow.com/q/87938/101
