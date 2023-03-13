using CoreFramework.AllFeatures.Parent;
using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.Interactions
{
    public class GoogleInteractions : Features
    {
        public GoogleInteractions(Browser browser) : base(browser)
        {

        }

        public GoogleInteractions GoTo()
        {
            Browser.GoToURL(GoogleAbilities.GoogleURL);

            return this;
        }

        public GoogleInteractions Search(string text)
        {
            GoTo();
            GoogleElements.SearchBarInput.SendKeys(text);

            return this;
        }
    }
}
