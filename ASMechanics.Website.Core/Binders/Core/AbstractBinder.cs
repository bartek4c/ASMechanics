using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Website.Core.Binders.Core
{
    public class AbstractBinder : IBinder
    {
        public void Bind(Umbraco.Core.Models.IPublishedContent model, object viewModel)
        {
            throw new NotImplementedException();
        }

        public bool CanHandle(Type modelType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Type> AcceptedTypes
        {
            get { throw new NotImplementedException(); }
        }
    }
}
