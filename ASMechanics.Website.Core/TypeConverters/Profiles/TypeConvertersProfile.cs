using ASMechanics.Website.Core.Models.Core;
using AutoMapper;
using System.Collections.Generic;

namespace ASMechanics.Website.Core.TypeConverters.Profiles
{
    public class TypeConvertersProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<string, HtmlText>().ConvertUsing(new StringToHtmlTextConverter());
            Mapper.CreateMap<string, List<LinkVm>>().ConvertUsing(new StringToListOfLinkVmConverter());
        }
    }
}
