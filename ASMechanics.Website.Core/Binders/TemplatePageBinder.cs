using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMechanics.Website.Core.Binders.Core;
using Umbraco.Core.Models;
using ASMechanics.Website.Core.Models.Pages.Base;
using ASMechanics.Website.Core.Models.Pages;
using AutoMapper;

namespace ASMechanics.Website.Core.Binders
{
    public class TemplatePageBinder : AbstractBinder
    {
        public override IContentModel Bind(IPublishedContent model)
        {
            return Mapper.Map<TemplatePageVm>(model);
        }

        public override IEnumerable<Type> AcceptedTypes
        {
            get { return new Type[] { typeof(TemplatePageVm) }; }
        }
    }
}
