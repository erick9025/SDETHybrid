using CoreFramework.API;
using CoreFramework.Logger;
using RestSharp;
using System;

namespace CoreFramework.AllFeatures.Api.ParentClasses
{
    public abstract class BaseApiInteractions
    {
        public BaseApiInteractions()
        {

        }

        //------------------------- FIELDS THAT CAN BE UPDATED ONLY VIA AssignMainExecutionValues() CALL -------------------
        protected string EndpointOriginal { get; private set; } //= "";
        protected Method RestMethod { get; private set; }
        protected int ExpectedStatusCode { get; private set; } //= 200;

        //------------- PROTECTED FIELDS
        protected IRestResponse ServiceResponse { get; private set; }
        protected string BaseURL { get; set; }              //   https://rahulshettyacademy.com
        protected string EndpointURL { get; set; }          //   maps/api/place/add/json?key=qaclick123
        protected string FinalURLStructure { get; private set; }    //   https://rahulshettyacademy.com/maps/api/place/get/json?key={keyValue}}&place_id={placeId}        

        protected void AssignMainExecutionValues(string endpoint, Method method, int expectedResponseStatusCode)
        {
            //Default Endpoint URL in case user forgets to replace keys (or in case he does not have need to replace something)
            EndpointURL = endpoint;

            //Store 3 values for future use
            EndpointOriginal = endpoint;
            RestMethod = method;
            ExpectedStatusCode = expectedResponseStatusCode;

            Log.Info($"Will execute method '{method}' with expected code '{expectedResponseStatusCode}' and endpoint '{endpoint}'");

            FinalURLStructure = BaseURL + EndpointOriginal;

            Log.Info("Final URL Structure [" + FinalURLStructure + "] (for reference only)");
        }

        protected void ExecuteRESTRequest(object body = null)
        {
            string completeUrl = BaseURL + "/" + EndpointURL;
            RestCore restCore;
            RestRequest restRequest;

            restCore = new RestCore(completeUrl);
            restRequest = restCore.CreateRequestWithHeaders(RestMethod);

            if(body == null)
            {
                ServiceResponse = restCore.ExecuteRequestWithoutBody(restRequest);
            }
            else
            {
                ServiceResponse = restCore.ExecuteRequestWithBody(restRequest, body);
            }

            Log.AssertAreEquals(ExpectedStatusCode, Convert.ToInt32(ServiceResponse.StatusCode), "Status code validation");
        }        
    }
}