public ServiceInstaller() {
    //... Installer code here
    this.AfterInstall += new InstallEventHandler(ServiceInstaller_AfterInstall);
}

void ServiceInstaller_AfterInstall(object sender, InstallEventArgs e) {
    using (var sc = new ServiceController(serviceInstaller.ServiceName)) {
         sc.Start();
    }
}

//https://pt.stackoverflow.com/q/103949/101
