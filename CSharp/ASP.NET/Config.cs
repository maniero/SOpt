using System;
using Microsoft.Framework.ConfigurationModel;

namespace Microsoft.AspNet.Hosting {
    internal class ConfigureHostingEnvironment : IConfigureHostingEnvironment {
        private IConfiguration _config;
        private const string EnvironmentKey = "ASPNET_ENV"; //esta é a variável de ambiente
        public ConfigureHostingEnvironment(IConfiguration config) => _config = config;
        public void Configure(IHostingEnvironment hostingEnv) => hostingEnv.EnvironmentName = _config.Get(EnvironmentKey) ?? hostingEnv.EnvironmentName;
    }
}

//https://pt.stackoverflow.com/q/51808/101
