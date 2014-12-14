using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMechanics.Websites.Core.Models.Core
{
    public class LinkVm
    {
        public bool NewWindow { get; set; }
        public bool Selected { get; set; }
        public string Target { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int? NodeId { get; set; }
    }
}
