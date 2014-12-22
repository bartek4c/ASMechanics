using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMechanics.Website.Core.Binders.Core;
using ASMechanics.Website.Core.Models.Pages;
using ASMechanics.Website.Core.UmbracoServices;
using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.Binders
{
    public class HomePageBinder : AbstractBinder
    {
        public override void Bind(IPublishedContent model, object viewModel)
        {
            var basePageModel = (HomePageVm)viewModel;
            basePageModel.UmbracoService = new UmbracoService();
        }

        public override IEnumerable<Type> AcceptedTypes
        {
            get { return new Type[] { typeof(HomePageVm) }; }
        }
    }
}
