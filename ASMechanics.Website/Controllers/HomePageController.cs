using ASMechanics.Website.Core.Binders;
using ASMechanics.Website.Core.Binders.Core;
using ASMechanics.Website.Core.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using umbraco.cms.businesslogic.web;
using umbraco.NodeFactory;
using Umbraco.Core.Models;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;


namespace ASMechanics.Website.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public HomePageController()
        {    
        }

        public ActionResult DefaultPage(RenderModel model)
        {
            var vm = new StandardPageVm();

            var _binder = new StandardPageBinder();

            _binder.Bind(model.Content, vm);

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