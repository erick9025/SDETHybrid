using CoreFramework.AllFeatures;
using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCasesNUnit
{
    public class MapsTests : NagarroTest
    {
        [Test, Category("Api_Maps"), Order (1)]
        public void API_CompleteFlow_3Requests()
        {
            Features.Maps
                .PostAddPlace()
                .PutUpdatePlace()
                .GetPlaceDetails();
        }

        [Test, Category("Api_Maps"), Order(2)]
        public void API_MultipleGets()
        {
            Features.Maps
                .GetMultiplePlacesDetails();
        }
    }
}
