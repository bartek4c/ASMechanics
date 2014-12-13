using ASMechanics.Websites.Core.TypeConverters;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Websites.Core
{
    public class TypeConvertersProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<int, string>().ConvertUsing(new IntToStringConverter());
        }
    }
}
