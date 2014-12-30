using ASMechanics.Website.Core.Models.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Umbraco.Core.Dynamics;
using Umbraco.Web;

namespace ASMechanics.Website.Core.TypeConverters
{
    public class StringToListOfLinkVmConverter : ITypeConverter<string, List<LinkVm>>
    {
        public List<LinkVm> Convert(ResolutionContext context)
        {
            var xmlContent = (string)context.SourceValue;

            var links = (context.DestinationValue != null) ? (List<LinkVm>)context.DestinationValue : new List<LinkVm>();

            //Guard against empty link list
            if (String.IsNullOrEmpty(xmlContent))
            {
                return links;
            }

            var doc = new XmlDocument();
            doc.LoadXml(xmlContent);

            foreach (XmlNode xnode in doc.DocumentElement.ChildNodes)
            {
                var link = new LinkVm();
                link.Title = xnode.Attributes["title"].Value;
                link.Selected = false;
                link.NewWindow = xnode.Attributes["newwindow"].Value != "0";

                string type = xnode.Attributes["type"].Value;

                if (type == "internal")
                {
                    // Get the 'Nice URL' for the link from content service
                    var node = new UmbracoHelper(UmbracoContext.Current).TypedContent(int.Parse(xnode.Attributes["link"].Value));

                    try
                    {
                        link.Url = node.Url;
                        link.NodeId = node.Id;
                    }
                    catch (Exception ex)
                    {
                        //Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                    }
                }
                links.Add(link);
            }
            return links;            
        }
        
        //public List<LinkViewModel> Convert(ResolutionContext context)
        //{
        //    var links = context.DestinationValue as List<LinkViewModel>;

        //    var xmlContent = context.SourceValue as string;

        //    // Guard against empty link list
        //    if (String.IsNullOrEmpty(xmlContent))
        //    {
        //        return links;
        //    }

        //    if (context.DestinationValue == null)
        //    {
        //        links = new List<LinkViewModel>();
        //    }

        //    var doc = new XmlDocument();
        //    doc.LoadXml(xmlContent);

        //    foreach (XmlNode xnode in doc.DocumentElement.ChildNodes)
        //    {
        //        string title = xnode.Attributes["title"].Value;
        //        string type = xnode.Attributes["type"].Value;
        //        bool newWindow = xnode.Attributes["newwindow"].Value != "0";
        //        string link = "#";
        //        int nodeId = -1;

        //        if (type == "internal")
        //        {
        //            // Get the 'Nice URL' for the link from content service
        //            var node = _umbracoService.UmbracoHelper.TypedContent(int.Parse(xnode.Attributes["link"].Value));

        //            try
        //            {
        //                link = node.Url;
        //                nodeId = node.Id;
        //            }
        //            catch (Exception ex)
        //            {
        //                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
        //            }
        //        }
        //        else if (type == "media")
        //        {
        //            var media = _umbracoService.UmbracoHelper.TypedMedia(int.Parse(xnode.Attributes["link"].Value));

        //            try
        //            {
        //                link = media.Url;
        //                nodeId = media.Id;
        //            }
        //            catch (Exception ex)
        //            {
        //                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
        //            }
        //        }
        //        else
        //        {
        //            link = xnode.Attributes["link"].Value;
        //        }

        //        if (link != "#")
        //        {
        //            var linkObj = new LinkViewModel() { Text = title, NewWindow = newWindow, Url = link, NodeId = nodeId, Target = newWindow ? "_blank" : null };
        //            links.Add(linkObj);
        //        }
        //    }

        //    return links;
        //}
    }
}
