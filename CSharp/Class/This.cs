public HelpController(HttpConfiguration config) => Configuration = config;

public HelpController() => this.HelpController(GlobalConfiguration.Configuration);

public HelpController(HttpConfiguration config = GlobalConfiguration.Configuration);

//https://pt.stackoverflow.com/q/206302/101
