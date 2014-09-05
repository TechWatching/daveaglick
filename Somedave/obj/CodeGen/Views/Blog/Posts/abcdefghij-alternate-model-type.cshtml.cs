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

namespace Somedave.Views.Blog.Posts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Posts/abcdefghij-alternate-model-type.cshtml")]
    public partial class abcdefghij_alternate_model_type : Somedave.BlogPostViewPage<dynamic>
    {
        public abcdefghij_alternate_model_type()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Blog\Posts\abcdefghij-alternate-model-type.cshtml"
  
    Title = "Getting an HtmlHelper for an Alternate Model Type";
    Published = new DateTime(2012, 10, 17);
    Tags = new[] { "ASP.NET", "ASP.NET MVC", "MVC", "HTML helpers", "HtmlHelper" };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<p>First off, I\'m back and have a lot of little tips to blog about over the n" +
"ext several weeks. Since my last post I have changed jobs and am no longer worki" +
"ng with Mono, Gtk#, or XML on a daily basis. However, I am still developing for " +
"the .NET platform and have been focusing recently on ASP.NET MVC and Entity Fram" +
"ework. Now, on to the topic at hand...</p>\r\n\r\n<p>By default, the Razor view engi" +
"ne for ASP.NET MVC rigs up a nice little object of type <code>HtmlHelper&lt;TMod" +
"el&gt;</code> for us that can be used as the first argument in extension methods" +
". This convention gets used a lot for all sorts of HTML helpers such as automati" +
"c generation of form controls, validation messages, etc. In most cases, you want" +
" to operate on the model type that was passed to the view and the default <code>" +
"HtmlHelper</code> instance works fine. However, there are some cases when you mi" +
"ght need access to a <code>HtmlHelper</code> that has a different generic type t" +
"han that of the view\'s model. Some of these include displaying the display name " +
"metadata (such as that from a <code>DisplayAttribute</code> on your model) in co" +
"lumn headers for a table (in which case the view\'s model is probably an <code>IE" +
"numerable</code> and not the actual type that you want metadata for) and display" +
"ing form controls for models included through encapsulation inside the view\'s mo" +
"del. Regardless of the reason, it\'s not easy to create an <code>HtmlHelper</code" +
"> for a type other than the specified model - you can\'t just construct one from " +
"scratch because the HtmlHelper class expects a lot of information about the cont" +
"ext and data in the view.</p>\r\n\r\n<p>Thankfully there are ways to make this work." +
" I would like to give a lot of credit to Tahir Hassan for his answer to a <a");

WriteLiteral(" href=\"http://stackoverflow.com/questions/1321254/asp-net-mvc-typesafe-html-textb" +
"oxfor-with-different-outputmodel\"");

WriteLiteral(@">related question on Stack Overflow</a>. In his answer he describes an HTML helper extension method that can get a new <code>HtmlHelper</code> of a requested type. The code in this article is based very heavily on his code with very few changes. Below is the code for a series of extension methods and direct methods (more on these in a later post) for getting an alternate <code>HtmlHelper</code>.</p>

<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(">public static class HtmlHelpers\r\n{\r\n    public static HtmlHelper&lt;TModel&gt; F" +
"or&lt;TModel&gt;(this HtmlHelper helper) where TModel : class, new()\r\n    {\r\n   " +
"     return For&lt;TModel&gt;(helper.ViewContext, helper.ViewDataContainer.ViewD" +
"ata, helper.RouteCollection);\r\n    }\r\n\r\n    public static HtmlHelper&lt;TModel&g" +
"t; For&lt;TModel&gt;(this HtmlHelper helper, TModel model)\r\n    {\r\n        retur" +
"n For&lt;TModel&gt;(helper.ViewContext, helper.ViewDataContainer.ViewData, helpe" +
"r.RouteCollection, model);\r\n    }\r\n\r\n    public static HtmlHelper&lt;TModel&gt; " +
"For&lt;TModel&gt;(ViewContext viewContext, ViewDataDictionary viewData, RouteCol" +
"lection routeCollection) where TModel : class, new()\r\n    {\r\n        TModel mode" +
"l = new TModel();\r\n        return For&lt;TModel&gt;(viewContext, viewData, route" +
"Collection, model);\r\n    }\r\n\r\n    public static HtmlHelper&lt;TModel&gt; For&lt;" +
"TModel&gt;(ViewContext viewContext, ViewDataDictionary viewData, RouteCollection" +
" routeCollection, TModel model)\r\n    {\r\n        var newViewData = new ViewDataDi" +
"ctionary(viewData) { Model = model };\r\n        ViewContext newViewContext = new " +
"ViewContext(\r\n            viewContext.Controller.ControllerContext,\r\n           " +
" viewContext.View,\r\n            newViewData,\r\n            viewContext.TempData,\r" +
"\n            viewContext.Writer);\r\n        var viewDataContainer = new ViewDataC" +
"ontainer(newViewContext.ViewData);\r\n        return new HtmlHelper&lt;TModel&gt;(" +
"newViewContext, viewDataContainer, routeCollection);\r\n    }\r\n\r\n    private class" +
" ViewDataContainer : System.Web.Mvc.IViewDataContainer\r\n    {\r\n        public Sy" +
"stem.Web.Mvc.ViewDataDictionary ViewData { get; set; }\r\n\r\n        public ViewDat" +
"aContainer(System.Web.Mvc.ViewDataDictionary viewData)\r\n        {\r\n            V" +
"iewData = viewData;\r\n        }\r\n    }\r\n}</code></pre>\r\n\r\n<p>Once these extension" +
" methods are available you can write things like the following in your views:</p" +
">\r\n\r\n<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(">&lt;th&gt;");

WriteLiteral("@(Html.For&lt;TableItemModel&gt;().DisplayNameFor(m => m.ThisColumnProperty))&lt;" +
"/th&gt;</code></pre>\r\n\r\n<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(">&lt;td&gt;");

WriteLiteral(@"@(Html.For(rowItem).TextBoxFor(m => m.ThisColumnProperty))&lt;/td&gt;</code></pre>

<p>By itself this is already a powerful capability and opens up your views to additional model types easily. In my next post I'll detail how to use the non-extension versions with the MVC wrappers for KendoUI to automatically set the title of a bound grid column.</p>
");

        }
    }
}
#pragma warning restore 1591
