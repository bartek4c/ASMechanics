using ASMechanics.Website.Core.Models.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.Binders.Core
{
    public interface IBinder
    {
        void Bind(IPublishedContent model, object viewModel);
        bool CanHandle(Type modelType);
        IEnumerable<Type> AcceptedTypes { get; }
    }
}
