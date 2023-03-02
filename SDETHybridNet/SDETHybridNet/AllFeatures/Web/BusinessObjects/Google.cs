using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.BusinessObjects
{
    public class Google : BusinessObject
    {
        public Google(Browser browser) : base(browser)
        {

        }

        public Google Search(string text)
        {
            GoogleInteractions
                .Search(text);

            return this;
        }
    }
}
