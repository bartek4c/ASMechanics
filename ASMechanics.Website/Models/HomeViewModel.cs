using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMechanics.Website.Models
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel() {}

        public HomeViewModel(string heading, string content)
        {
            MainHeading = heading;
            MainContent = content;
        }

        public string MainHeading { get; set; }
        public string MainContent { get; set; }

        public IEnumerable<string> Tags { get; set; }
    }
}