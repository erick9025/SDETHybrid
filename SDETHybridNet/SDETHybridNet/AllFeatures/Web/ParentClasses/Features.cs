using CoreFramework.Driver;
using CoreFramework.AllFeatures.Web.Elements;
using CoreFramework.AllFeatures.Web.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using CoreFramework.AllFeatures.Api;
using CoreFramework.AllFeatures.Web.Abilities;

namespace CoreFramework.AllFeatures.Web.ParentClasses
{
    public class Features
    {
        protected Browser Browser { get; set; }

        public Features(Browser browser)
        {
            Browser = browser;
        }

        #region Web Elements

        private GoogleElements _googleElements;

        protected GoogleElements GoogleElements
        {
            get
            {
                return _googleElements ?? (_googleElements = new GoogleElements(Browser));
            }
        }

        private AmazonElements _amazonElements;

        protected AmazonElements AmazonElements
        {
            get
            {
                return _amazonElements ?? (_amazonElements = new AmazonElements(Browser));
            }
        }

        private FacebookElements _facebookElements;

        protected FacebookElements FacebookElements
        {
            get
            {
                return _facebookElements ?? (_facebookElements = new FacebookElements(Browser));
            }
        }

        #endregion Web Elements

        #region Web Interactions

        private GoogleInteractions _googleInteractions;

        protected GoogleInteractions GoogleInteractions
        {
            get
            {
                return _googleInteractions ?? (_googleInteractions = new GoogleInteractions(Browser));
            }
        }

        private AmazonInteractions _amazonInteractions;

        protected AmazonInteractions AmazonInteractions
        {
            get
            {
                return _amazonInteractions ?? (_amazonInteractions = new AmazonInteractions(Browser));
            }
        }

        private FacebookInteractions _facebookInteractions;

        protected FacebookInteractions FacebookInteractions
        {
            get
            {
                return _facebookInteractions ?? (_facebookInteractions = new FacebookInteractions(Browser));
            }
        }

        private StandardMethods _standardMethods;

        protected StandardMethods StandardMethods
        {
            get
            {
                return _standardMethods ?? (_standardMethods = new StandardMethods(Browser));
            }
        }

        #endregion Web Interactions

        #region Api Interactions

        private MapsApiInteractions _mapsApi;

        protected MapsApiInteractions MapsApi
        {
            get
            {
                return _mapsApi ?? (_mapsApi = new MapsApiInteractions());
            }
        }

        #endregion Api Interactions

        #region Abilities

        private GoogleAbilities _googleAbilities;

        internal GoogleAbilities GoogleAbilities
        {
            get
            {
                return _googleAbilities ?? (_googleAbilities = new GoogleAbilities());
            }
        }

        private AmazonAbilities _amazonAbilities;

        internal AmazonAbilities AmazonAbilities
        {
            get
            {
                return _amazonAbilities ?? (_amazonAbilities = new AmazonAbilities());
            }
        }

        private FacebookAbilities _facebookAbilities;

        internal FacebookAbilities FacebookAbilities
        {
            get
            {
                return _facebookAbilities ?? (_facebookAbilities = new FacebookAbilities());
            }
        }

        #endregion Abilities
    }
}
