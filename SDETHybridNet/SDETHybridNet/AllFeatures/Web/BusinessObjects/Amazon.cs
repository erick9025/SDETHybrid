using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.BusinessObjects
{
    public class Amazon : BusinessObject
    {
        public Amazon(Browser browser) : base(browser)
        {

        }

        public Amazon SearchProduct(string productWanted)
        {
            AmazonInteractions
                .SearchProduct(productWanted);
            return this;
        }

        public Amazon SelectResultByOrdinal(int ordinal)
        {
            AmazonInteractions
                .SelectResultByOrdinal(ordinal);
            return this;
        }
    }
}
