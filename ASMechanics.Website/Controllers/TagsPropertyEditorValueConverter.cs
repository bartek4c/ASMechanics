using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web;

namespace ASMechanics.Website.Controllers
{
    public class TagsPropertyEditorValueConverter
    {
        public bool IsConverterFor(string type)
        {
            return (type).Equals("tags");
        }

        public IEnumerable<string> ConvertPropertyValue(object value)
        {
            if (UmbracoContext.Current != null && value != null && value.ToString() != string.Empty)
            {
                return value.ToString().Split(',').AsEnumerable();
            }
            return null;
        }
    }
}