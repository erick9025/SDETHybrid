using CoreFramework.Driver;
using CoreFramework.AllFeatures.Web;
using CoreFramework.Logger;
using NUnit.Framework;
using TestCasesNUnit.TestCases.ParentClasses;
using CoreFramework.AllFeatures.Web.ParentClasses;

namespace TestCases.TestCases.ParentClasses
{
    public abstract class WebTest : BaseTest
    {
        protected FeatureObjects Features { get; set; }
        private bool _waitTime = true;

        protected Browser Browser { get; set; }

        protected override void InitializeFramework()
        {
            Browser = new Browser();

            Browser.InitializeBrowser(BrowserTarget.Chrome);
            Browser.Wait(1);
            InitializeLog();
        }

        #region test annotations
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Log.Info("This gets executed one time per run BEFORE");

            InitializeFramework();
            InitializePages();
        }

        [SetUp]
        public void Setup()
        {
            //Disable wait when dealing with API
            if(TestContext.CurrentContext.Test.Name.Contains("API_"))
            {
                _waitTime = false;
            }

            Log.Info("This gets executed BEFORE EVERY test");
            if(_waitTime) Browser.Wait(1);
        }

        [TearDown]
        public void TearDown()
        {
            Log.Info("This gets executed AFTER EVERY test");
            if (_waitTime) Browser.Wait(1);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Log.Info("This gets executed one time per run AFTER");

            CloseBrowser();
            CloseLog();
        }
        #endregion test annotations

        public void InitializePages()
        {
            Features = new FeatureObjects(Browser);
        }

        public void CloseBrowser()
        {
            Browser.Wait(2);
            Browser.QuitBrowser();
        }
    }
}
