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
    
    #line 1 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/WidgetStatus.cshtml")]
    public partial class _Views_Shared_EditorTemplates_WidgetStatus_cshtml_ : System.Web.Mvc.WebViewPage<string>
    {
        public _Views_Shared_EditorTemplates_WidgetStatus_cshtml_()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 5 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
 if (Model == ContentStatus.Published.ToString())
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-action-ok bcms-js-action-ok\"");

WriteAttribute("title", Tuple.Create(" title=\"", 207), Tuple.Create("\"", 256)
            
            #line 7 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
, Tuple.Create(Tuple.Create("", 215), Tuple.Create<System.Object, System.Int32>(RootGlobalization.WidgetStatus_Published
            
            #line default
            #line hidden
, 215), false)
);

WriteLiteral(">");

            
            #line 7 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
                                                                                               Write(RootGlobalization.WidgetStatus_Published);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 8 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
}
else if (Model == ContentStatus.Draft.ToString())
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-action-draft\"");

WriteAttribute("title", Tuple.Create(" title=\"", 398), Tuple.Create("\"", 443)
            
            #line 11 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
, Tuple.Create(Tuple.Create("", 406), Tuple.Create<System.Object, System.Int32>(RootGlobalization.WidgetStatus_Draft
            
            #line default
            #line hidden
, 406), false)
);

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
                                                                            Write(RootGlobalization.WidgetStatus_Draft);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 12 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-action-draft\"");

WriteAttribute("title", Tuple.Create(" title=\"", 536), Tuple.Create("\"", 594)
            
            #line 15 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
, Tuple.Create(Tuple.Create("", 544), Tuple.Create<System.Object, System.Int32>(RootGlobalization.WidgetStatus_PublishedWithDraft
            
            #line default
            #line hidden
, 544), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
                                                                                         Write(RootGlobalization.WidgetStatus_PublishedWithDraft);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 16 "..\..\Views\Shared\EditorTemplates\WidgetStatus.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
