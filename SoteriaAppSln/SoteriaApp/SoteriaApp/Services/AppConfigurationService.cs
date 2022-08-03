using SoteriaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoteriaApp.Services
{
    public class AppConfigurationService : IAppConfiguration
    {
        private string _soteriaServerUrl;

        public string SoteriaServerUrl { get => _soteriaServerUrl; set => _soteriaServerUrl = value; }

        public AppConfigurationService()
        {
#if LOCALSERVER
            _soteriaServerUrl = "https://10.0.2.2:7047/";
#else
            _soteriaServerUrl = "http://localhost:5114";
#endif
        }
    }


}
