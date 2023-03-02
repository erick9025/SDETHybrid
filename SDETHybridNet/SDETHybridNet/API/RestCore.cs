using System.Collections.Generic;
using System.Text.Json;
using CoreFramework.Logger;
using RestSharp;

namespace CoreFramework.API
{
    public class RestCore
    {
        RestClient restClient;
        RestRequest restRequest;
        string requestURL;

        public RestCore(string url)
        {
            restClient = new RestClient(url);
            requestURL = url;
            Log.Info(requestURL);
        }
       
        public RestRequest CreateRequestWithHeaders(Method method)
        {
            restRequest = new RestRequest(requestURL, method);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddHeader("Content-Type", "application/json");

            return restRequest;
        }

        public RestRequest CreateRequestWithHeaders(Method method, Dictionary<string, string> headers, bool addDefault = true)
        {
            restRequest = new RestRequest(requestURL, method);
            restRequest.RequestFormat = DataFormat.Json;

            foreach (string header in headers.Keys)
            {
                restRequest.AddHeader(header, headers[header]);
            }

            //added boolean to avoid adding default content-type
            if (addDefault)
                restRequest.AddHeader("Content-Type", "application/json");

            return restRequest;
        }

        //Object class and properties should be "public" because deserialization happens in NuGet (external assembly)
        public IRestResponse ExecuteRequestWithBody(RestRequest restRequest, object body)
        {
            //How to customize property names and values with System.Text.Json
            //https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/customize-properties?pivots=dotnet-core-3-1
            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(body, serializeOptions);
            string className = body.GetType().Name;

            Log.Info($"JSON representation of '{className}' body: " + json);

            if(json.Equals("{}"))
            {
                Log.AssertFail("JSON body should NOT be empty");
            }            

            restRequest.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            IRestResponse serviceReponse = restClient.Execute(restRequest);

            return serviceReponse;
        }

        public IRestResponse ExecuteRequestWithoutBody(RestRequest restRequest)
        {
            restRequest.AddParameter("application/json; charset=utf-8", ParameterType.RequestBody);
            IRestResponse serviceReponse = restClient.Execute(restRequest);

            return serviceReponse;
        }
    }
}
