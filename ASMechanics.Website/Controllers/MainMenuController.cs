using ASMechanics.Website.Core.Models.Core;
using ASMechanics.Website.Core.Models.Pages.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using Umbraco.Core.Dynamics;
using System.Web.Mvc;

namespace ASMechanics.Website.Controllers
{
    public class MainMenuController : RenderMvcController
    {
        public ActionResult MainMenu()
        {
            var model = BuildMainMenu("");

            return PartialView("MainMenu", model);
        }
        
        public List<LinkVm> BuildMainMenu(string selectedItem)
        {
            var mainMenuItem = new UmbracoHelper(UmbracoContext.Current)
                .AssignedContentItem.AncestorOrSelf("HomePage")
                .Children.Where(p => p.DocumentTypeAlias == "MainMenu")
                .ToList().FirstOrDefault();

            var mainMenu = Mapper.Map<MainMenuVm>(mainMenuItem).MainMenu;
            foreach (var mm in mainMenu)
            {
                mm.Selected = (mm.Title == selectedItem) ? true : false;
            } 
            return mainMenu;
        }
    }
}