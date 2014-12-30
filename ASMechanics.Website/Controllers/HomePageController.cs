using ASMechanics.Website.Core.Binders;
using ASMechanics.Website.Core.Binders.Core;
using ASMechanics.Website.Core.Models.Core;
using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace ASMechanics.Website.Controllers
{
    public class HomePageController : RenderMvcController
    {
        private IBinder _binder;

        public HomePageController()
        {
            _binder = new HomePageBinder();
        }

        public ActionResult DefaultPage(RenderModel model)
        {
            //var test = base.BuildMainMenu(model.Content.Name);

            var vm = _binder.Bind(model.Content);
            return View("Home", vm);
        }

        #region redundant code
        /*
        Document document = new Document(model.Content.Id, true);

        var helper1 = new UmbracoHelper(UmbracoContext.Current, model.Content);
        var helper2 = new UmbracoHelper(UmbracoContext.Current);
            
        var node = new Node(model.Content.Id);
            
        var names = new List<string>();

        foreach (var property in model.Content.Properties)
        {
            var name = document.getProperty(property.Alias).PropertyType.DataTypeDefinition.DataType.DataTypeName;
            names.Add(name);
        }

        public void Test<T>() where T : ViewModelBase
        {
            var poco = Activator.CreateInstance<T>();
        }
        */
        #endregion
    }
}