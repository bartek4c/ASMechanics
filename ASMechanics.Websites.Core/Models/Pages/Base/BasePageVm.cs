using ASMechanics.Websites.Core.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Websites.Core.Models.Pages.Base
{
    public abstract class BasePageVm : IPageVm
    {
        public ImageVm PageLogo { get; set; }

        public List<LinkVm> MainMenu { get; set; }
        public List<LinkVm> FooterMenu { get; set; }

        public string PageTitle { get; set; }
        public string MetadataDescription { get; set; }
        public string MetadataKeywords { get; set; } 
    }
}
