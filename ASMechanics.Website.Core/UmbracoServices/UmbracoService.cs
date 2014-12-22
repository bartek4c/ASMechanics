using System;
using Umbraco.Web;

namespace ASMechanics.Website.Core.UmbracoServices
{
    public class UmbracoService : IUmbracoService
    {
        private UmbracoContext _umbracoContext;
        private UmbracoHelper _umbracoHelper;

        public UmbracoService()
        {
            _umbracoContext = UmbracoContext.Current;
            _umbracoHelper = new UmbracoHelper(_umbracoContext);
        }

        public UmbracoHelper UmbracoHelper
        {
            get { return _umbracoHelper; }
        }

        public UmbracoContext UmbracoContext
        {
            get { return _umbracoContext; }
        }
    }
}
