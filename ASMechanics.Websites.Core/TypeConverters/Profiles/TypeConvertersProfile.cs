using AutoMapper;

namespace ASMechanics.Websites.Core.TypeConverters.Profiles
{
    public class TypeConvertersProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<int, string>().ConvertUsing(new IntToStringConverter());
        }
    }
}
