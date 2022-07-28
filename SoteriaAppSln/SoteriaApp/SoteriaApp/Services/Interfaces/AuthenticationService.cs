using Newtonsoft.Json;
using SoteriaApp.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoteriaApp.Services.Interfaces
{
    public  class AuthenticationService : IAuthentication
    {
        private HttpClient _httpClient;
        private IAppConfiguration _appConfiguration;
      
        public AuthenticationService(IAppConfiguration appConfiguration,IHttpNativeHandler handler)
        {
            _httpClient= new HttpClient(handler.GetHttpClientHandler());
            _appConfiguration=appConfiguration;


        }

        public async Task<bool> Authenticate(string email, string Password)
        {
            Uri uri = new Uri(_appConfiguration.SoteriaServerUrl + "api/authentication");
            try
            {
                var request = new AuthRequest() { Email = email, Password = Password };
                string requestJson = JsonConvert.SerializeObject(request);

                StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;

                response = await _httpClient.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();
                    var valueResponse = JsonConvert.DeserializeObject<bool>(contentResponse);
                    return valueResponse;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR{0}", ex.Message);
            }

            return false;
        }
        
    }
}
