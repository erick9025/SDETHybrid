using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.API.Abilities;
using CoreFramework.Driver;
using RestSharp;

namespace CoreFramework.API.BusinessObjects
{
    public class Maps : BusinessObject
    {
        public Maps()
        {
        }

        public Maps PostAddPlace()
        {
            MapsApiInteractions
                .PostAddPlace(MapsAbilities.EndpointPostAddPlace, Method.POST, 200);

            return this;
        }

        public Maps PutUpdatePlace()
        {
            MapsApiInteractions
                .PutUpdatePlace(MapsAbilities.EndpointPutUpdatePlace, Method.PUT, 200);

            return this;
        }

        public Maps GetPlaceDetails()
        {
            MapsApiInteractions
                .GetPlaceDetails(MapsAbilities.EndpointGetPlaceDetails, Method.GET, 200);

            return this;
        }

        public Maps GetMultiplePlacesDetails()
        {
            MapsApiInteractions
                .GetMultiplePlacesDetails(MapsAbilities.EndpointGetPlaceDetails, Method.GET, 404);

            return this;
        }
    }
}
