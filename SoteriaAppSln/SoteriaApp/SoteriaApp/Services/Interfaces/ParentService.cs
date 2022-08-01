using Newtonsoft.Json;
using SoteriaProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoteriaApp.Services.Interfaces
{
    public  class ParentService
    {
        private HttpClient _httpClient;
        private IAppConfiguration _appConfiguration;

        public ParentService(IAppConfiguration appConfiguration, IHttpNativeHandler handler)
        {
            _httpClient = new HttpClient(handler.GetHttpClientHandler());
            _appConfiguration = appConfiguration;
        }


        public async Task<ParentProfile> CreateProfile(ParentProfile parentProfile)
        {
            Uri uri = new Uri(_appConfiguration.SoteriaServerUrl + "api/parentProfile");

            try
            {
                var profile = new ParentProfile() {parentProfile};
                string requestJson = JsonConvert.SerializeObject(profile);

                StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await _httpClient.PostAsync(uri, content);


                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();

                    var valueResponse = JsonConvert.DeserializeObject<ParentProfile>(contentResponse);

                    return valueResponse;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return null;
        }
    }
}
