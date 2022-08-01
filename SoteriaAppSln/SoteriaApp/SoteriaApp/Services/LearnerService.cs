using Newtonsoft.Json;
using SoteriaApp.Services.Interfaces;
using SoteriaProjectWebApi.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SoteriaApp.Services
{
    public class LearnerService : ILearnerService
    {
        private HttpClient _httpClient;
        private IAppConfiguration _appConfiguration;

        public LearnerService (IAppConfiguration appConfiguration,IHttpNativeHandler handler)
        {
            _httpClient = new HttpClient(handler.GetHttpClientHandler());
            _appConfiguration = appConfiguration;   
        }

       
        public async Task<LearnerProfile> CreateProfile (LearnerProfile learnerProfile)
        {
            Uri uri = new Uri(_appConfiguration.SoteriaServerUrl + "api/learnerProfile");

            try
            {
                var profile = new LearnerProfile() {learnerProfile};
                string requestJson = JsonConvert.SerializeObject(profile);

                StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await _httpClient.PostAsync(uri, content);


                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();

                    var valueResponse = JsonConvert.DeserializeObject<LearnerProfile>(contentResponse);

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
