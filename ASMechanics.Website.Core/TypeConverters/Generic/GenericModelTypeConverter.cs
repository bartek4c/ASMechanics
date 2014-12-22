using ASMechanics.Website.Core.Models.Core;
using ASMechanics.Website.Core.Models.Pages.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace ASMechanics.Website.Core.TypeConverters.Generic
{
    public class GenericModelTypeConverter : ITypeConverter<IPublishedContent, IContentModel>
    {
        public IContentModel Convert(ResolutionContext context)
        {
            //to verified in details
            var destinationModel = context.DestinationValue;

            if (destinationModel == null)
            {
                destinationModel = Activator.CreateInstance(context.DestinationType);
            }

            // Let's check we've got something to work with
            // Return the empty view model if not...
            if (context.SourceValue == null)
            {
                return (IContentModel)destinationModel;
            }

            IPublishedContent sourceModel = (IPublishedContent)context.SourceValue;

            foreach (var prop in destinationModel.GetType().GetProperties())
            {
                var umbracoProperty = sourceModel.Properties.FirstOrDefault(x => x.Alias.ToLower() == prop.Name.ToLower());

                if (umbracoProperty != null)
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(destinationModel, umbracoProperty.Value.ToString());
                    }
                    if (prop.PropertyType == typeof(HtmlTextVm))
                    {
                        prop.SetValue(destinationModel, Mapper.Map<string, HtmlTextVm>(umbracoProperty.Value.ToString()));
                    }
                }
            }

            return destinationModel as IContentModel;
        }
    }
}
