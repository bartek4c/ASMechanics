using ASMechanics.Websites.Core.Models.Core;
using ASMechanics.Websites.Core.Models.Pages.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace ASMechanics.Websites.Core.Binders
{
    public class Binder : IBinder
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
                }
            }
            
            return viewModel;
        }
    }
}
