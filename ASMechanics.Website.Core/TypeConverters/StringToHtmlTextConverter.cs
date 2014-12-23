using ASMechanics.Website.Core.Models.Core;
using AutoMapper;

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
