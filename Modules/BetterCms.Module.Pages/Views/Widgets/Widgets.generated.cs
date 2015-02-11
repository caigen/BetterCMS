﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Widgets
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
    
    #line 1 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Pages.ViewModels.SiteSettings;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Views\Widgets\Widgets.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Views\Widgets\Widgets.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 11 "..\..\Views\Widgets\Widgets.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/Widgets.cshtml")]
    public partial class Widgets : System.Web.Mvc.WebViewPage<SiteSettingWidgetListViewModel>
    {
        public Widgets()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Widgets\Widgets.cshtml"
  
    var controller = (CmsControllerBase)ViewContext.Controller;
    var roles = string.Format("{0},{1},{2}", 
        RootModuleConstants.UserRoles.PublishContent, 
        RootModuleConstants.UserRoles.EditContent,
        RootModuleConstants.UserRoles.DeleteContent);
    var canViewPages = controller.SecurityService.IsAuthorized(roles);
    
    Action<ColumnBuilder<SiteSettingWidgetItemViewModel>> columns = column =>
    {
        column.EditButtonColumn(renderId: false);
        
        column.For(f => string.Format("<a class=\"bcms-tables-link bcms-grid-item-edit-button bcms-widget-name\" data-id=\"{0}\">{1}</a>", f.Id, f.WidgetName))
            .Named(PagesGlobalization.SiteSettings_Widgets_NameColumn)
            .SortColumnName("WidgetName")
            .HeaderAttributes(@style => "width: 245px;")
            .Encode(false);

        column.For(f => Html.EditorFor(e => f.Status, "WidgetStatus"))
            .Named(PagesGlobalization.SiteSettings_Widgets_StatusColumn)
            .SortColumnName("Status")
            .Attributes(@class => "bcms-widget-status");

        if (canViewPages)
        {
            column.For(f => string.Format("<a class=\"bcms-template-usage\" title=\"{1}\">&nbsp;</a>", f.Id, PagesGlobalization.SiteSettings_Widgets_Usage))
                .Named("")
                .HeaderAttributes(@style => "width: 15px;")
                .Sortable(false)
                .Encode(false);
        }
        
        column.HistoryButtonColumn(renderId: false);
        
        column.DeleteButtonColumn(renderId:false);
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 59 "..\..\Views\Widgets\Widgets.cshtml"
 using (Html.BeginForm<WidgetsController>(f => f.Widgets(null), FormMethod.Post, new { @id = "bcms-widgets-form", @class = "bcms-ajax-form" }))
{
    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Widgets\Widgets.cshtml"
Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\Widgets\Widgets.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-twocols-title-block\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-large-titles\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\Widgets\Widgets.cshtml"
                                  Write(PagesGlobalization.SiteSettings_Widgets_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-btn-links-main\"");

WriteLiteral(" id=\"bcms-create-widget-button\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Widgets\Widgets.cshtml"
                                                                   Write(PagesGlobalization.SiteSettings_Widgets_AddNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-btn-links-main\"");

WriteLiteral(" id=\"bcms-register-widget-button\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Widgets\Widgets.cshtml"
                                                                     Write(PagesGlobalization.SiteSettings_Widgets_RegisterNew);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 68 "..\..\Views\Widgets\Widgets.cshtml"
       Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-editor-field-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-widget-search-btn\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Widgets\Widgets.cshtml"
                                                                Write(PagesGlobalization.SiteSettings_Widgets_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"bcms-featured-grid bcms-clearfix\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 72 "..\..\Views\Widgets\Widgets.cshtml"
       Write(Html.RenderPaging(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>    \r\n");

            
            #line 75 "..\..\Views\Widgets\Widgets.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Widgets\Widgets.cshtml"
Write(Html.SiteSettingsMessagesBox());

            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Widgets\Widgets.cshtml"
                                   

    
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Widgets\Widgets.cshtml"
Write(Html
          .Grid(Model.Items)
          .Sort(Model.GridOptions)
          .Columns(columns)
          .Attributes(@class => "bcms-tables")          
          .RowAttributes(delegate(GridRowViewData<SiteSettingWidgetItemViewModel> row)
                  {
                      return new Dictionary<string, object>
                              {
                                    {"data-id", row.Item.Id},
                                    {"data-original-id", row.Item.OriginalId},
                                    {"data-type", row.Item.WidgetType},
                                    {"data-version", row.Item.Version},
                                    {"data-original-version", row.Item.OriginalVersion}
                              };
              })
          .RenderUsing(new EditableHtmlTableGridRenderer<SiteSettingWidgetItemViewModel>()));

            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Widgets\Widgets.cshtml"
                                                                                            
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-widget-list-row-template\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 98 "..\..\Views\Widgets\Widgets.cshtml"
Write(Html
        .Grid(new List<SiteSettingWidgetItemViewModel> {new SiteSettingWidgetItemViewModel()})
        .Columns(columns)
        .Attributes(@class => "bcms-tables")
        .RenderUsing(new HtmlTableGridSingleRowRenderer<SiteSettingWidgetItemViewModel>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
