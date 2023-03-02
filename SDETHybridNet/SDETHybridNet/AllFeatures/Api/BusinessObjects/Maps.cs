using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.API.Abilities;
using CoreFramework.Driver;
using RestSharp;

namespace CoreFramework.API.BusinessObjects
{
    public class Maps : BusinessObject
    {
        private readonly MapsAbilities abilities;

        public Maps(Browser browser) : base(browser)
        {
            abilities = new MapsAbilities();
        }

        public Maps PostAddPlace()
        {
            MapsApiInteractions
                .PostAddPlace(abilities.EndpointPostAddPlace, Method.POST, 200);

            return this;
        }

        public Maps PutUpdatePlace()
        {
            MapsApiInteractions
                .PutUpdatePlace(abilities.EndpointPutUpdatePlace, Method.PUT, 200);

            return this;
        }

        public Maps GetPlaceDetails()
        {
            MapsApiInteractions
                .GetPlaceDetails(abilities.EndpointGetPlaceDetails, Method.GET, 200);

            return this;
        }

        public Maps GetMultiplePlacesDetails()
        {
            MapsApiInteractions
                .GetMultiplePlacesDetails(abilities.EndpointGetPlaceDetails, Method.GET, 404);

            return this;
        }
    }
}
