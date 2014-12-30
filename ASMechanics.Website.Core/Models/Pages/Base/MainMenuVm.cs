using ASMechanics.Website.Core.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Website.Core.Models.Pages.Base
{
    public class MainMenuVm : IContentModel
    {
        public List<LinkVm> MainMenu { get; set; }
    }
}
