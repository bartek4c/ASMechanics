using System;
using System.Collections.Generic;
using ASMechanics.Website.Core.Binders.Core;
using ASMechanics.Website.Core.Models.Pages;
using Umbraco.Core.Models;
using AutoMapper;
using ASMechanics.Website.Core.Models.Pages.Base;

namespace ASMechanics.Website.Core.Binders
{
    public class MainMenuBinder : AbstractBinder
    {
        public override IContentModel Bind(IPublishedContent model)
        {
            return Mapper.Map<MainMenuVm>(model);
        }

        public override IEnumerable<Type> AcceptedTypes
        {
            get { return new Type[] { typeof(MainMenuVm) }; }
        }
    }
}
