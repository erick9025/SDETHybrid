using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCases.TestCases
{
    public class MapsTests : ApiTest
    {
        [Test, Category("Api_Maps"), Order (1)]
        public void API_CompleteFlow_3Requests()
        {
            Services.Maps
                .PostAddPlace()
                .PutUpdatePlace()
                .GetPlaceDetails();
        }

        [Test, Category("Api_Maps"), Order(2)]
        public void API_MultipleGets()
        {
            Services.Maps
                .GetMultiplePlacesDetails();
        }
    }
}
