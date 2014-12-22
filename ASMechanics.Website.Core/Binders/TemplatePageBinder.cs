using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASMechanics.Website.Core.Binders.Core;

namespace ASMechanics.Website.Core.Binders
{
    public class TemplatePageBinder : AbstractBinder
    {
        public override void Bind(Umbraco.Core.Models.IPublishedContent model, object viewModel)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Type> AcceptedTypes
        {
            get { throw new NotImplementedException(); }
        }
    }
}
