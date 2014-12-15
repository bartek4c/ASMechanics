using ASMechanics.Websites.Core.Models.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Websites.Core.TypeConverters
{
    public class StringToHtmlTextConverter : ITypeConverter<string, HtmlText>
    {
        public HtmlText Convert(ResolutionContext context)
        {
            return new HtmlText() {
                Content = context.SourceValue.ToString()
            };
        }
    }
}
