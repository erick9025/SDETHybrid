using CoreFramework.API.Abilities;
using CoreFramework.API.BusinessObjects;
using CoreFramework.Driver;

namespace CoreFramework.AllFeatures.Api.ParentClasses
{
    public class ServiceObjects
    {       
        public ServiceObjects()
        {
            
        }

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
