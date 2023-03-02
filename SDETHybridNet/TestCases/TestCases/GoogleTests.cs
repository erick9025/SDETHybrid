using CoreFramework.AllFeatures;
using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCasesNUnit
{
    public class GoogleTests : NagarroTest
    {
        [Test, Category("Google")]
        public void SearchSomething()
        {
            Features.Google
               .Search("El dolar hoy");
        }
    }
}
