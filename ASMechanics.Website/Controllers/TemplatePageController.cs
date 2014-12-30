using ASMechanics.Website.Core.Binders;
using ASMechanics.Website.Core.Binders.Core;
using System.Web.Mvc;
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
            return View(model.Content.Name.Replace(" ", ""), vm);
        }
    }
}