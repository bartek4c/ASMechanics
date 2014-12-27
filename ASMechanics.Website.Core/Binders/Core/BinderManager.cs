using System.Collections.Generic;
using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.Binders.Core
{
    public class BinderManager : IBinderManager
    {
        private IList<IBinder> _binders { get; set; }

        public BinderManager()
        {
            //temporarily
            _binders = new List<IBinder>();
            _binders.Add(new HomePageBinder());
        }

        public void Bind(IPublishedContent model, object viewModel)
        {
            //Mapper.Map(model, viewModel);

            foreach (var binder in _binders)
            {
                if (binder.CanHandle(viewModel.GetType()))
                {
                    binder.Bind(model);
                }
            }
        }
    }
}
