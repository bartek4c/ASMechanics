using ASMechanics.Website.Core.Models.Core;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace ASMechanics.Website.Core.TypeConverters
{
    public class StringToListOfLinkVmConverter : ITypeConverter<string, List<LinkVm>>
    {
        public List<LinkVm> Convert(ResolutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
