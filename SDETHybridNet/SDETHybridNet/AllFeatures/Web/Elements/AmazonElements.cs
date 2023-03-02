using CoreFramework.Driver;
using CoreFramework.AllFeatures.Parent;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.Elements
{
    public class AmazonElements : BasePage
    {
        public AmazonElements(Browser browser) : base(browser)
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='twotabsearchtextbox']")]
        public IWebElement SearchBarInput { get; set; }

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#nav-link-accountList-nav-line-1")]
        public IWebElement HelloUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[contains(@data-image-latency,'s-product-image')]")]
        public IList<IWebElement> ResultScreenList { get; set; }
    }
}
