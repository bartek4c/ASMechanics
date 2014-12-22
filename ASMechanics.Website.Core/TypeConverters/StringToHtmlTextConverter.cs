using ASMechanics.Website.Core.Models.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Website.Core.TypeConverters
{
    public class StringToHtmlTextConverter : ITypeConverter<string, HtmlTextVm>
    {
        public HtmlTextVm Convert(ResolutionContext context)
        {
            return new HtmlTextVm() {
                Content = context.SourceValue.ToString()
            };
        }
    }
}
