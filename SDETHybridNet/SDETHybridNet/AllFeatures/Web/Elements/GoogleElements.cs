using CoreFramework.Driver;
using CoreFramework.AllFeatures.Parent;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.Elements
{
    public class GoogleElements : BasePage
    {
        public GoogleElements(Browser browser) : base(browser)
        {

        }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBarInput { get; set; }
    }
}
