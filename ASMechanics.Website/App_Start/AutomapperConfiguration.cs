using ASMechanics.Website.Core.Models.Pages.Base;
using ASMechanics.Website.Core.TypeConverters.Generic;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Umbraco.Core.Models;

namespace ASMechanics.Website.App_Start
{
    /// <summary>
    /// Sets up cofiguration for automapper
    /// http://www.velir.com/blog/index.php/2012/08/27/organizing-automappers-map-configurations-in-mvc/
    /// </summary>
    public class AutomapperConfiguration
    {
        public static void Configure()
        {
            // Get all classes which inherit from Profile class, which is used to register type converters
            List<Profile> profiles = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(p => p.GetTypes())
                .Where(c => typeof(Profile).IsAssignableFrom(c) && typeof(Profile) != c && !c.IsAbstract)
                .Select(fp => Activator.CreateInstance(fp) as Profile)
                .ToList();

            // Initialize AutoMapper with each instance of the profile found.
            Mapper.Initialize(a => profiles.ForEach(a.AddProfile));
            
            // Automatic Umbraco Model Converter
            var modelType = typeof(IContentModel);

            var modelTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => modelType.IsAssignableFrom(p) && !p.IsAbstract && !p.IsInterface)
                .ToList();

            foreach (var model in modelTypes)
            {
                Mapper.CreateMap(typeof(IPublishedContent), model).ConvertUsing<GenericModelTypeConverter>();
            }
        }
    }
}