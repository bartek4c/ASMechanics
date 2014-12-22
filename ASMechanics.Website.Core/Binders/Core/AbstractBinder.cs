using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Website.Core.Binders.Core
{
    public abstract class AbstractBinder : IBinder
    {
        public abstract void Bind(Umbraco.Core.Models.IPublishedContent model, object viewModel);
        
        public abstract IEnumerable<Type> AcceptedTypes { get; }

        public bool CanHandle(Type modelType)
        {
            if (AcceptedTypes == null)
                return false;

            foreach (var type in AcceptedTypes)
            {
                if (type.IsAssignableFrom(modelType))
                    return true;
            }

            return false;
        }
    }
}
