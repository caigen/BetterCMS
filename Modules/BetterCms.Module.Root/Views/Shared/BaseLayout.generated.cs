﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\BaseLayout.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\BaseLayout.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\BaseLayout.cshtml"
    using BetterCms.Module.Root.ViewModels.Cms;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/BaseLayout.cshtml")]
    public partial class BaseLayout : System.Web.Mvc.WebViewPage<RenderPageViewModel>
    {
        public BaseLayout()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\BaseLayout.cshtml"
  
    Layout = "RootLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("CmsMetaTitle", () => {

WriteLiteral("\r\n    <title>");

            
            #line 13 "..\..\Views\Shared\BaseLayout.cshtml"
      Write(Model.MetaTitle);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

});

WriteLiteral("\r\n");

DefineSection("CmsMeta", () => {

WriteLiteral("    \r\n");

            
            #line 17 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.Metadata != null)
    {
        foreach (var metaData in Model.Metadata)
        {
            metaData.Render(Model, (ViewContext.Controller as CmsControllerBase).SecurityService, Html);
        }
    }

            
            #line default
            #line hidden
});

DefineSection("CmsHeadStyles", () => {

WriteLiteral("   \r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n        .bcms-clearfix:after {\r\n            content: \".\";\r\n            visibil" +
"ity: hidden;\r\n            display: block;\r\n            height: 0;\r\n            c" +
"lear: both;\r\n        }\r\n    </style>\r\n");

});

WriteLiteral("\r\n");

DefineSection("CmsHeadScripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("CmsHeadScripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("CmsScripts", () => {

WriteLiteral("\r\n");

            
            #line 42 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.JavaScripts != null)
    {
        
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.RenderPageCustomJavaScript(Model.JavaScripts));

            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Shared\BaseLayout.cshtml"
                                                           
    }

            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 49 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("Styles", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 51 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Shared\BaseLayout.cshtml"
     if (Model.Stylesheets != null)
    {
        
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(Html.RenderPageCustomCss(Model.Stylesheets));

            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Shared\BaseLayout.cshtml"
                                                    
    }

            
            #line default
            #line hidden
});

DefineSection("HeadScripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 57 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("HeadScripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 60 "..\..\Views\Shared\BaseLayout.cshtml"
Write(RenderSection("Scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("DoctypeTag", () => {

WriteLiteral(" \r\n");

            
            #line 63 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Shared\BaseLayout.cshtml"
     if (IsSectionDefined("DoctypeTag"))
    {
        
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(RenderSection("DoctypeTag", false));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Shared\BaseLayout.cshtml"
                                           
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<!DOCTYPE html>\r\n");

            
            #line 70 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("HtmlTag", () => {

WriteLiteral(" \r\n");

            
            #line 73 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\Shared\BaseLayout.cshtml"
     if (IsSectionDefined("HtmlTag"))
    {
        
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(RenderSection("HtmlTag", false));

            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Shared\BaseLayout.cshtml"
                                        
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<html>\r\n");

            
            #line 80 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

DefineSection("BodyTag", () => {

WriteLiteral(" \r\n");

            
            #line 83 "..\..\Views\Shared\BaseLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\Shared\BaseLayout.cshtml"
     if (IsSectionDefined("BodyTag"))
    {
        
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Shared\BaseLayout.cshtml"
   Write(RenderSection("BodyTag", false));

            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Shared\BaseLayout.cshtml"
                                        
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("<body ");

            
            #line 89 "..\..\Views\Shared\BaseLayout.cshtml"
           Write(Html.RenderBodyAttributes());

            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\Shared\BaseLayout.cshtml"
                                       Write(RenderSection("BodyAttributes", false));

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 90 "..\..\Views\Shared\BaseLayout.cshtml"
    }

            
            #line default
            #line hidden
});

        }
    }
}
#pragma warning restore 1591
