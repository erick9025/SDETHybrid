using CoreFramework.Driver;
using CoreFramework.AllFeatures.Parent;
using CoreFramework.AllFeatures.ParentClasses;
using CoreFramework.Logger;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections;
using System.Collections.Generic;

namespace CoreFramework.AllFeatures.Web
{
    public class StandardMethods : BasePage
    {
        public StandardMethods(Browser browser) : base(browser)
        {
            //Do additional things
        }

        public StandardMethods Click(IWebElement element, string elementDescription)
        {
            WebBrowser.Click(element);
            Log.Info($"Clicked Element: {elementDescription}");

            return this;
        }

        public StandardMethods EnterText(IWebElement element, string elementDescription, string inputText)
        {
            WebBrowser.EnterText(element, inputText);
            Log.Info($"Entered '{inputText}' into '{elementDescription}'");

            return this;
        }

        public StandardMethods Wait(int timeSeconds)
        {
            WebBrowser.Wait(timeSeconds);
            Log.Info($"Waiting {timeSeconds} Seconds");
            return this;
        }

    }
}
