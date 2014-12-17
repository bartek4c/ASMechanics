using ASMechanics.Website.Core.Models.Components;
using ASMechanics.Website.Core.Models.Components.Interfaces;
using ASMechanics.Website.Core.Models.Core;
using ASMechanics.Website.Core.Models.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Website.Core.Models.Pages
{
    public class StandardPageVm : BasePageVm
    {
        //Components tab in umbraco office
        public ITopPageComponent TopPageComponent { get; set; }
        public List<ISidePageComponent> SidePageComponents { get; set; }

        //Content tab in umbraco office
        public string MainHeader { get; set; }
        public string SubHeader { get; set; }
        public HtmlText ContentText { get; set; }
    }
}
