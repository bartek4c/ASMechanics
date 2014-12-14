using ASMechanics.Websites.Core.Models.Pages;
using AutoMapper;
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
    public class HomeController : RenderMvcController
    {
        public ActionResult DefaultPage(RenderModel model)
        {
            var testString = Mapper.Map<int, string>(5);

            var vm = new StandardPageVm() {
                MainHeader = "Main Header",
                SubHeader = "Sub Header"
            };

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