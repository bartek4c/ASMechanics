using ASMechanics.Website.Core.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Website.Core.Models.Pages.Base
{
    public abstract class BasePageVm : IPageVm
    {
        public List<LinkVm> MainMenu { get; set; }
        public bool DisplayMainMenu { get; set; }
        public List<LinkVm> FooterMenu { get; set; }
        public bool DisplayFooterMenu { get; set; }

        public string PageTitle { get; set; }
        public string MetadataDescription { get; set; }
        public string MetadataKeywords { get; set; } 
    }
}
