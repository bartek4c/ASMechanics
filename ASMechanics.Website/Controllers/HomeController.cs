using ASMechanics.Website.Models;
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

            //constructor takes two parameters
            var vm = new HomeViewModel(model.Content.GetProperty("mainHeading").Value.ToString(),
                model.Content.GetProperty("mainContent").Value.ToString());

            TagsPropertyEditorValueConverter converter = new TagsPropertyEditorValueConverter();

            var test1 = model.Content.GetProperty("tags");

            if (converter.IsConverterFor(test1.Alias))
            {
                vm.Tags = converter.ConvertPropertyValue(test1.Value);
            }

            var type = test1.GetType();

            //converter.IsConverterFor(test1..)


            var testString = Mapper.Map<int, string>(5);

            var test2 = model.Content.GetProperty("tags").Value;

            Test<HomeViewModel>();

            return View("Home", vm);
        }

        public void Test<T>() where T : ViewModelBase
        {
            var poco = Activator.CreateInstance<T>();
        }
    }
}