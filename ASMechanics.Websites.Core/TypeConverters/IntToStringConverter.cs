using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Websites.Core.TypeConverters
{
    public class IntToStringConverter : ITypeConverter<int, string>
    {
        public IntToStringConverter() { }

        public string Convert(ResolutionContext context)
        {
            return string.Format("Custom number: {0}", context.SourceValue.ToString());
        }
    }
}
