using ASMechanics.Websites.Core.Models.Core;
using AutoMapper;

namespace ASMechanics.Websites.Core.TypeConverters.Profiles
{
    public class TypeConvertersProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<int, string>().ConvertUsing(new IntToStringConverter());
            Mapper.CreateMap<string, HtmlText>().ConvertUsing(new StringToHtmlTextConverter());
        }
    }
}
