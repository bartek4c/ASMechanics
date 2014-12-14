using ASMechanics.Websites.Core.Models.Components;
using ASMechanics.Websites.Core.Models.Components.Interfaces;
using ASMechanics.Websites.Core.Models.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Websites.Core.Models.Pages
{
    public class StandardPageVm : BasePageVm
    {
        public ITopPageComponent TopPageComponent { get; set; }
        public bool HideTopPageComponent { get; set; }
        public List<ISidePageComponent> SidePageComponents { get; set; }

        public string MainHeader { get; set; }
        public string SubHeader { get; set; }

        public string ContentText { get; set; }
    }
}
