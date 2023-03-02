using System;
using System.Collections.Generic;
using System.Linq;
using CoreFramework.AllFeatures.Api.ParentClasses;
using CoreFramework.API.Deserialize;
using CoreFramework.API.Serialize;
using CoreFramework.Logger;
using CoreFramework.Utilities;
using Newtonsoft.Json;
using RestSharp;

namespace CoreFramework.AllFeatures.Api
{
    public class MapsApiInteractions : BaseApiInteractions
    {
        //Responses objects
        private PostLocationAddResponse postLocationAddResponse;
        private PutLocationUpdateResponse putLocationUpdateResponse;
        private GetLocationResponse getLocationResponse;

        //Constants
        private string ORIGINAL_ADDRESS = "111 First Address (Original)";
        private string NEW_ADDRESS = "222 Second Address (Updated)";
        private string KEY_VALUE = "qaclick123";

        //Fields that we want to store
        private string newPlaceId = null;

        public MapsApiInteractions()
        {
            BaseURL = "https://rahulshettyacademy.com";
            Log.InfoFocus("API domain: " + BaseURL);
        }

        #region Public methods

        public MapsApiInteractions PostAddPlace(string endpoint, Method method, int expectedStatusCode)
        {
            AssignMainExecutionValues(endpoint, method, expectedStatusCode);
            Post_AddPlace();

            return this;
        }

        public MapsApiInteractions PutUpdatePlace(string endpoint, Method method, int expectedStatusCode)
        {
            AssignMainExecutionValues(endpoint, method, expectedStatusCode);
            Put_UpdatePlace();

            return this;
        }

        public MapsApiInteractions GetPlaceDetails(string endpoint, Method method, int expectedStatusCode)
        {
            AssignMainExecutionValues(endpoint, method, expectedStatusCode);
            Get_PlaceDetails();

            return this;
        }

        public MapsApiInteractions GetMultiplePlacesDetails(string endpoint, Method method, int expectedStatusCode)
        {
            AssignMainExecutionValues(endpoint, method, expectedStatusCode);
            Get_MultiplePlacesDetails();

            return this;
        }

        #endregion Public methods

        #region Private methods

        #endregion Private methods

        private void Post_AddPlace()
        {
            PostLocationAddBody body = null;

            Log.Info("Start :: Post_AddPlace");

            //Create instance (later will be serialized: Java Class --> JSON string)
            body = new PostLocationAddBody();

            body.Accuracy = 50;
            body.Name = "Erick Test";
            body.PhoneNumber = "33 1861 2829";
            body.Address = ORIGINAL_ADDRESS;
            body.Website = "https://google.com";
            body.Language = "French-IN";
            body.Location = new PostLocationAddBodyLocation(-38.383494, 33.427362);
            body.Types = new List<string>
            {
                "restaurant", "bar", "cafe"
            };

            //Replace keys in URL
            EndpointURL = EndpointOriginal.ReplaceCustomKey("keyValue", KEY_VALUE);

            //Execute REST 
            ExecuteRESTRequest(body);

            //Deserialize
            postLocationAddResponse = JsonConvert.DeserializeObject<PostLocationAddResponse>(ServiceResponse.Content);
            Log.AssertIsNotNull(postLocationAddResponse, "postLocationAddResponse instance should NOT be null");

            //Store place id from deserialized instance
            newPlaceId = postLocationAddResponse.PlaceId;
            Log.Info("Generated newPlaceId: " + newPlaceId);

            //Validations TODO		
            Log.Info("End :: Post_AddPlace");
        }

        private void Put_UpdatePlace()
        {
            PutLocationUpdateBody body = null;

            Log.Info("Start :: Put_UpdatePlace");

            body = new PutLocationUpdateBody(newPlaceId, NEW_ADDRESS, KEY_VALUE);

            //Replace keys in URL
            EndpointURL = TestUtilities.ReplaceCustomKey(EndpointOriginal, "keyValue", KEY_VALUE);

            //Execute REST 
            ExecuteRESTRequest(body);

            //Deserialize
            putLocationUpdateResponse = JsonConvert.DeserializeObject<PutLocationUpdateResponse>(ServiceResponse.Content);
            Log.AssertIsNotNull(putLocationUpdateResponse, "putLocationUpdateResponse instance should NOT be null");

            //Store place id from deserialized instance
            string message = putLocationUpdateResponse.Message;
            Log.AssertAreEquals("Address successfully updated", message, "Message validation");

            //Validations TODO	
            Log.Info("End :: Put_UpdatePlace");
        }

        private void Get_PlaceDetails()
        {
            Log.Info("Start :: Get_PlaceDetails");

            //Replace keys in URL
            EndpointURL = TestUtilities.ReplaceCustomKey(EndpointOriginal, "keyValue", KEY_VALUE);
            EndpointURL = TestUtilities.ReplaceCustomKey(EndpointURL, "place_idValue", newPlaceId);

            //Execute REST 
            ExecuteRESTRequest();

            //Deserialize
            getLocationResponse = JsonConvert.DeserializeObject<GetLocationResponse>(ServiceResponse.Content);
            Log.AssertIsNotNull(getLocationResponse, "getLocationResponse instance should NOT be null");

            //Store place id from deserialized instance
            string getAddress = getLocationResponse.Address;

            Log.AssertAreEquals(NEW_ADDRESS, getAddress, "Address updated validation");
            Log.AssertAreNotEquals(ORIGINAL_ADDRESS, getAddress, "Address old validation");

            //Validations TODO
            Log.Info("End :: Get_PlaceDetails");
        }

        private void Get_MultiplePlacesDetails()
        {
            List<string> listPlaceIds = new List<string>();
            listPlaceIds.Add("AAA");
            listPlaceIds.Add("BBB");
            listPlaceIds.Add("CCC");
            listPlaceIds.Add("DDD");
            listPlaceIds.Add("EEE");

            Log.Info("Start :: Get_MultiplePlacesDetails");

            foreach (string placeId in listPlaceIds) 
            {
                //Replace keys in URL
                EndpointURL = EndpointOriginal.ReplaceCustomKey("keyValue", KEY_VALUE);
                EndpointURL = EndpointOriginal.ReplaceCustomKey("place_idValue", placeId);

                //Execute REST
                ExecuteRESTRequest();
                Log.Info("**************************************");
            }

            Log.Info("End :: Get_MultiplePlacesDetails");
        }
    }
}