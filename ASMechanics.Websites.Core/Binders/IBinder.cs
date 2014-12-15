using ASMechanics.Websites.Core.Models.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace ASMechanics.Websites.Core.Binders
{
    public interface IBinder
    {
        IPageVm Bind(IPublishedContent umbracoModel, IPageVm viewModel);
    }
}
