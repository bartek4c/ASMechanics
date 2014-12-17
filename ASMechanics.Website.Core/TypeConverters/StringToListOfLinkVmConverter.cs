using ASMechanics.Website.Core.Models.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
