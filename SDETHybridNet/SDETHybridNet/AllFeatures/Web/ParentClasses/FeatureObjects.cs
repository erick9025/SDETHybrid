using CoreFramework.AllFeatures.Web.BusinessObjects;
using CoreFramework.API.BusinessObjects;
using CoreFramework.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFramework.AllFeatures.Web.ParentClasses
{
    public class FeatureObjects
    {
        protected Browser Browser { get; set; }

        public FeatureObjects(Browser browser)
        {
            Browser = browser;
        }

        #region Web

        private Google _google;

        public Google Google
        {
            get
            {
                return _google ?? (_google = new Google(Browser));
            }
        }

        private Amazon _amazon;

        public Amazon Amazon
        {
            get
            {
                return _amazon ?? (_amazon = new Amazon(Browser));
            }
        }

        private Facebook _facebook;

        public Facebook Facebook
        {
            get
            {
                return _facebook ?? (_facebook = new Facebook(Browser));
            }
        }

        #endregion Web

        #region Api

        private Maps _maps;

        public Maps Maps
        {
            get
            {
                return _maps ?? (_maps = new Maps());
            }
        }

        #endregion Api
    }
}
