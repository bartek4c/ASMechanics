using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMechanics.Website.Core.Binders.Core;
using ASMechanics.Website.Core.Models.Pages;
using Umbraco.Core.Models;
using Umbraco.Web;
using AutoMapper;
using ASMechanics.Website.Core.Models.Pages.Base;

namespace ASMechanics.Website.Core.Binders
{
    public class HomePageBinder : AbstractBinder
    {
        public override IContentModel Bind(IPublishedContent model)
        {
            return Mapper.Map<HomePageVm>(model);
        }

        public override IEnumerable<Type> AcceptedTypes
        {
            get { return new Type[] { typeof(HomePageVm) }; }
        }
    }
}
