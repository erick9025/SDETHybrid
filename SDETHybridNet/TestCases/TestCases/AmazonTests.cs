using CoreFramework.AllFeatures;
using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCasesNUnit
{
    public class AmazonTests : NagarroTest
    {
        [Test, Category("Amazon"), Order (2)]
        public void SearchItem()
        {
            Features.Amazon
               .SearchProduct("Samsung Galaxy")
               .SelectResultByOrdinal(3);              
        }

        [Test, Category("Amazon"), Order(1)]
        public void SearchItem2()
        {
            Features.Amazon
               .SearchProduct("Xbox Series X")
               .SelectResultByOrdinal(5);
        }
    }
}
