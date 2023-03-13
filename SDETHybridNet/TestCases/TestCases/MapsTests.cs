using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCases.TestCases
{
    public class MapsTests : ApiTest
    {
        [Test, Category("API"), Order (1)]
        public void API_CompleteFlow_3Requests()
        {
            Services.Maps
                .PostAddPlace()
                .PutUpdatePlace()
                .GetPlaceDetails();
        }

        [Test, Category("API"), Order(2)]
        public void API_MultipleGets()
        {
            Services.Maps
                .GetMultiplePlacesDetails();
        }
    }
}
