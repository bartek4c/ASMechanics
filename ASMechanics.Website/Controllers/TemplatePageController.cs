using ASMechanics.Website.Core.Binders;
using ASMechanics.Website.Core.Binders.Core;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using umbraco.NodeFactory;
using Umbraco.Core.Models;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace ASMechanics.Website.Controllers
{
    public class TemplatePageController : RenderMvcController
    {
        private IBinder _binder;

        public TemplatePageController()
        {
            _binder = new TemplatePageBinder();
        }

        public ActionResult DefaultPage(RenderModel model)
        {
            var vm = _binder.Bind(model.Content);
            return View("AboutUs", vm);
        }
    }
}