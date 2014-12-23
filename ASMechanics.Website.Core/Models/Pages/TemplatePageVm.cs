using System.Collections.Generic;
using ASMechanics.Website.Core.Models.Components.Interfaces;
using ASMechanics.Website.Core.Models.Core;
using ASMechanics.Website.Core.Models.Pages.Base;

namespace ASMechanics.Website.Core.Models.Pages
{
    public class TemplatePageVm : BasePageVm
    {
        public List<ISidePageComponent> SidePageComponents { get; set; }

        public string MainHeader { get; set; }
        public string SubHeader { get; set; }
        public HtmlTextVm ContentText { get; set; }
    }
}
