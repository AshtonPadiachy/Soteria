using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SoteriaApp.Services.Interfaces
{
    public interface IHttpNativeHandler
    {
        HttpClientHandler GetHttpClientHandler();
    }
}
