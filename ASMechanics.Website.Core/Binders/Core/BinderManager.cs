using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.Binders.Core
{
    public class BinderManager : IBinderManager
    {
        private IList<IBinder> _binders { get; set; }

        public BinderManager(IList<IBinder> binders)
        {
            _binders = new List<IBinder>();
            _binders.Add(new StandardPageBinder());
        }

        public void Bind(IPublishedContent model, object viewModel)
        {
            Mapper.Map(model, viewModel);

            foreach (var binder in _binders)
            {
                if (binder.CanHandle(viewModel.GetType()))
                {
                    binder.Bind(model, viewModel);
                }
            }
        }
    }
}
