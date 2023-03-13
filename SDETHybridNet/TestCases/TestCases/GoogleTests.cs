using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCases.TestCases
{
    public class GoogleTests : WebTest
    {
        [Test, Category("Google")]
        public void SearchSomething()
        {
            Features.Google
               .Search("El dolar hoy");
        }
    }
}
