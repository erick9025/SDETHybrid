using CoreFramework.API.Abilities;

namespace CoreFramework.AllFeatures.Api.ParentClasses
{
    public class Services
    {       
        public Services()
        {
            
        }

        #region Api Interactions

        private MapsApiInteractions _mapsApiInteractions;

        protected MapsApiInteractions MapsApiMapsApiInteractions
        {
            get
            {
                return _mapsApiInteractions ?? (_mapsApiInteractions = new MapsApiInteractions());
            }
        }

        #endregion Api Interactions

        #region Abilities        

        private MapsAbilities _mapsAbilities;

        internal MapsAbilities MapsAbilities
        {
            get
            {
                return _mapsAbilities ?? (_mapsAbilities = new MapsAbilities());
            }
        }

        #endregion Abilities
    }
}
