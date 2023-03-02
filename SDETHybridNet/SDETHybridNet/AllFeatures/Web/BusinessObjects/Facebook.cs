using CoreFramework.AllFeatures.Web.ParentClasses;
using CoreFramework.Driver;
using CoreFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.BusinessObjects
{
    public class Facebook : BusinessObject
    {
        public Facebook(Browser browser) : base(browser)
        {

        }

        public Facebook CreateAccount(FacebookUser user)
        {
            FacebookInteractions
                .CreateAccount(user);

            return this;
        }
    }
}
