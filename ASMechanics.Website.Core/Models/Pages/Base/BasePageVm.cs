﻿using ASMechanics.Website.Core.Models.Core;
using System.Collections.Generic;

namespace ASMechanics.Website.Core.Models.Pages.Base
{
    public abstract class BasePageVm : IContentModel
    {
        public List<LinkVm> MainMenu { get; set; }
        public bool DisplayMainMenu { get; set; }
        public List<LinkVm> FooterMenu { get; set; }
        public bool DisplayFooterMenu { get; set; }
        public ImageVm BannerImage { get; set; }
        public bool DisplayBannerImage { get; set; }

        public string PageTitle { get; set; }
        public string MetadataDescription { get; set; }
        public string MetadataKeywords { get; set; } 
    }
}
