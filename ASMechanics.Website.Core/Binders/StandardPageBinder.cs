using ASMechanics.Website.Core.Binders.Core;
using ASMechanics.Website.Core.Models.Core;
using ASMechanics.Website.Core.Models.Pages.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.Binders
{
    public class StandardPageBinder : AbstractBinder
    {
        public IPageVm Bind(IPublishedContent umbracoModel, IPageVm viewModel)
        {
            var destinationProperties = viewModel.GetType().GetProperties();

            foreach (var prop in destinationProperties)
            {
                var umbracoProperty = umbracoModel.Properties.FirstOrDefault(x => x.Alias.ToLower() == prop.Name.ToLower());

                if (umbracoProperty != null)
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(viewModel, umbracoProperty.Value.ToString());
                    }
                    if (prop.PropertyType == typeof(HtmlText))
                    {
                        prop.SetValue(viewModel, Mapper.Map<string, HtmlText>(umbracoProperty.Value.ToString()));
                    }
                    if (prop.PropertyType == typeof(List<LinkVm>))
                    {
                        prop.SetValue(viewModel, Mapper.Map<string, List<LinkVm>>(umbracoProperty.Value.ToString()));
                    }
                }
            }
            
            return viewModel;
        }
    }
}
