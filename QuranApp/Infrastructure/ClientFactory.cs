using RestSharp;

namespace QuranApp.Infrastructure
{
    public static class ClientFactory
    {


        public static RestClient CreateRestClient(string endPoint)
        {
            return new RestClient(endPoint);
        }


    }
}
