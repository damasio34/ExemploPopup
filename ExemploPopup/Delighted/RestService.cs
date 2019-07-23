using ExemploPopup.Delighted.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPopup.Delighted
{
    public class RestService
    {
        const string API_KEY = "0JZDAlAo39I1keIjIQPUfQEAapT3f1hY:";

        // Basic auth
        private static HttpClient GetClient()
        {
            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{API_KEY}:")));
            var client = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = authValue }
            };
            return client;
        }

        public static async Task SendSurvei(SurveiResponse surveiResponse)
        {
            using (var _client = GetClient())
            {
                var uri = new Uri("https://api.delighted.com/v1/survey_responses.json");
                var json = JsonConvert.SerializeObject(surveiResponse, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await _client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode) System.Diagnostics.Debug.WriteLine(@"\tSend survei successfully saved.");
            }
        }
        public static async Task<People> CreateOrUpdatePerson(People people)
        {
            //try
            //{
                using (var _client = GetClient())
                {
                    var uri = new Uri("https://api.delighted.com/v1/people.json");
                    var json = JsonConvert.SerializeObject(people, new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = null;
                    response = await _client.PostAsync(uri, content);
                    if (response.IsSuccessStatusCode)
                    {
                        System.Diagnostics.Debug.WriteLine(@"\tPeople successfully saved.");
                        var result = response.Content.ReadAsStringAsync().Result;
                        var resultPeople = JsonConvert.DeserializeObject<People>(result);

                        return resultPeople;
                    }

                    return null;
                }
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.WriteLine(@"\tPeople successfully saved.");
            //}
        }
    }
}
