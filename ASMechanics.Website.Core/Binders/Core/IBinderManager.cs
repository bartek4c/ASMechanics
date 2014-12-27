using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.Binders.Core
{
    public interface IBinderManager
    {
        void Bind(IPublishedContent model, object viewModel);
    }
}
