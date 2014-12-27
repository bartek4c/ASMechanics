using ASMechanics.Website.Core.Models.Core;
using ASMechanics.Website.Core.Models.Pages.Base;
using System.Collections.Generic;

namespace ASMechanics.Website.Core.Models.Pages
{
    public class HomePageVm : BasePageVm
    {
        public List<ImageSliderVm> ImageSlider { get; set; }

        public string MainHeader { get; set; }
        public string SubHeader { get; set; }
        public HtmlTextVm ContentText { get; set; }
    }
}
