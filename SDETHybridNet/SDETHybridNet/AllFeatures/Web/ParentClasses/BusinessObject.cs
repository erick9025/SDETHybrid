using CoreFramework.Driver;
using CoreFramework.AllFeatures.Api;
using CoreFramework.AllFeatures.Web.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using CoreFramework.API.Abilities;

namespace CoreFramework.AllFeatures.Web.ParentClasses
{
    public abstract class BusinessObject
    {
        protected Browser Browser { get; set; }

        public BusinessObject()
        {
        }

        public BusinessObject (Browser browser)
        {
            Browser = browser;
        }

        #region Interactions Web

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

        #endregion Interactions Web

        #region Interactions Api

        private MapsApiInteractions _mapsApiInteractions;

        protected MapsApiInteractions MapsApiInteractions
        {
            get
            {
                return _mapsApiInteractions ?? (_mapsApiInteractions = new MapsApiInteractions());
            }
        }

        #endregion Interactions Api

        #region Abilities

        private MapsAbilities _mapsAbilities;

        protected MapsAbilities MapsAbilities
        {
            get
            {
                return _mapsAbilities ?? (_mapsAbilities = new MapsAbilities());
            }
        }

        #endregion Abilities
    }
}
