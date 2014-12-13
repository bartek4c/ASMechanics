using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

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
            /// Get all classes which inherit from Profile class, which is used to register type converters
            List<Profile> profiles = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(p => p.GetTypes())
                .Where(c => typeof(Profile).IsAssignableFrom(c) && typeof(Profile) != c && !c.IsAbstract && c != null)
                .Select(fp => Activator.CreateInstance(fp) as Profile)
                .ToList();

            // Initialize AutoMapper with each instance of the profile found.
            Mapper.Initialize(a => profiles.ForEach(a.AddProfile));
        }
    }
}