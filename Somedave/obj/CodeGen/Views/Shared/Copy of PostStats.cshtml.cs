#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Somedave.Views.Shared
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
    using FluentBootstrap;
    using Somedave;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Copy of PostStats.cshtml")]
    public partial class Copy_of_PostStats : Somedave.SomedaveViewPage<IBlogPost>
    {
        public Copy_of_PostStats()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Copy of PostStats.cshtml"
 if (Model.Tags != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div><strong>Tags</strong></div>\r\n");

WriteLiteral("    <div>\r\n");

            
            #line 7 "..\..\Views\Shared\Copy of PostStats.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Shared\Copy of PostStats.cshtml"
         foreach (string tag in Model.Tags)
        {
            
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\Copy of PostStats.cshtml"
       Write(Html.TagButton(tag));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\Copy of PostStats.cshtml"
                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>     \r\n");

            
            #line 12 "..\..\Views\Shared\Copy of PostStats.cshtml"
}     

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\Copy of PostStats.cshtml"
 if (Model.Published != default(DateTime))
{

            
            #line default
            #line hidden
WriteLiteral("    <div><strong>Published</strong></div>\r\n");

WriteLiteral("    <div>");

            
            #line 16 "..\..\Views\Shared\Copy of PostStats.cshtml"
    Write(Model.Published.ToLongDateString());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 17 "..\..\Views\Shared\Copy of PostStats.cshtml"
}

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\Copy of PostStats.cshtml"
 if (Model.Edited != default(DateTime))
{

            
            #line default
            #line hidden
WriteLiteral("    <div><strong>Edited</strong></div>\r\n");

WriteLiteral("    <div>");

            
            #line 21 "..\..\Views\Shared\Copy of PostStats.cshtml"
    Write(Model.Edited.ToLongDateString());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 22 "..\..\Views\Shared\Copy of PostStats.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
