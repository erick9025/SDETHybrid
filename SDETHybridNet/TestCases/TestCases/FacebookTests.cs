using CoreFramework.Utilities;
using NUnit.Framework;
using TestCases.TestCases.ParentClasses;

namespace TestCases.TestCases
{
    public class FacebookTests : NagarroTest
    {
        [Test, Category("Facebook"), Order(1)]
        public void CreateAccount_Man()
        {
            Features.Facebook
               .CreateAccount(FacebookUser.GenerateUser(Gender.Male));
        }

        [Test, Category("Facebook"), Order(2)]
        public void CreateAccount_Woman()
        {
            Features.Facebook
               .CreateAccount(FacebookUser.GenerateUser(Gender.Female));
        }

        [Test, Category("Facebook"), Order(3)]
        public void CreateAccount_NonBinary()
        {
            Features.Facebook
               .CreateAccount(FacebookUser.GenerateUser(Gender.NonBinary));
        }
    }
}
