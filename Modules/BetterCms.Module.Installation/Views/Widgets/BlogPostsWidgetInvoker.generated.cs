﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Widgets\BlogPostsWidgetInvoker.cshtml"
    using BetterCms.Core.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\BlogPostsWidgetInvoker.cshtml"
    using BetterCms.Module.Installation.Controllers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\BlogPostsWidgetInvoker.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/BlogPostsWidgetInvoker.cshtml")]
    public partial class _Views_Widgets_BlogPostsWidgetInvoker_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_BlogPostsWidgetInvoker_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Widgets\BlogPostsWidgetInvoker.cshtml"
  
    //Html.RenderAction("BlogPosts", "BlogWidget", new { model = Model });
    Html.RenderAction<BlogWidgetController>(c => c.BlogPosts(Model));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
