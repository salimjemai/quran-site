using System.Net;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.OAuth;
using Newtonsoft.Json;
using QuranApp.Models;
using RestSharp;

namespace QuranApp.Infrastructure
{
    public class QurantApiEngine
    {
        private readonly string _apiEndPoint = @"http://api.alquran.cloud/v1/";

        public QurantApiEngine()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        // all Quran editions http://api.alquran.cloud/v1/edition 
        public List<Edition>? GetAllEditions()
        {
            var endPoint = _apiEndPoint + "edition";
            var client = ClientFactory.CreateRestClient(endPoint);
            RestRequest request = new RestRequest {Method = Method.Get};
            request.AddHeader("content-type", "application/json");
            RestResponse response = client.Execute(request);
            if (response.StatusDescription != null && !response.StatusDescription.Equals("OK"))
            {
                throw new Exception($"Current application do not have access to this api {endPoint}");
            }

            var responseContent = response.Content ?? throw new ArgumentNullException("The API response is null");
            var allEditions = JsonConvert.DeserializeObject<EditionResponse>(responseContent);
            return allEditions?.data;
        }


        // Get specific edition http://api.alquran.cloud/v1/edition?format=audio&language=fr&type=versebyverse 


        // Get all languages http://api.alquran.cloud/v1/language


        // Get specific language http://api.alquran.cloud/v1/language/en //http://api.alquran.cloud/v1/edition/language/{{language}}


        // Get all types http://api.alquran.cloud/v1/type


        // Get specific Type (translation/tafsir) http://api.alquran.cloud/v1/type/translation // http://api.alquran.cloud/v1/edition/type/{{type}}


        // Get all format http://api.alquran.cloud/v1/format 


        // Get specific format http://api.alquran.cloud/v1/format/text //http://api.alquran.cloud/v1/edition/format/{{format}}

        // Get Full Quran by edition http://api.alquran.cloud/v1/quran/{{edition}}
        public QuranData GetQuranData(string edition) // ar.alafasy
        {
            FullQuranResponse fullQuran = null;
            try
            {
                //var endPoint = _apiEndPoint + $"quran/{edition}";
                //var client = ClientFactory.CreateRestClient(endPoint);
                //RestRequest request = new RestRequest {Method = Method.Get};
                //request.AddHeader("content-type", "application/json");
                //RestResponse response = client.Execute(request);
                //if (response.StatusDescription != null && !response.StatusDescription.Equals("OK"))
                //{
                //    throw new Exception($"Current application do not have access to this api {endPoint}");
                //}

                var quranText = ReadFile();
                //var responseContent = response.Content ?? throw new ArgumentNullException("The API response is null");
                fullQuran = JsonConvert.DeserializeObject<FullQuranResponse>(quranText);
                
            }
            catch (Exception ex)
            {

                var message = ex.Message;
            }
            return fullQuran?.data;
        }

        public string ReadFile()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"..\..\..\QuranJson\ArabicUthmaniQuran.txt");
            var response = File.ReadAllText(path);
            
            return response;
        }
    }
}
