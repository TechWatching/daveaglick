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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Posts/nested-grabs-in-gtksharp.cshtml")]
    public partial class nested_grabs_in_gtksharp : Somedave.BlogPostViewPage<dynamic>
    {
        public nested_grabs_in_gtksharp()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Blog\Posts\nested-grabs-in-gtksharp.cshtml"
  
    Title = "Nested Grabs In GtkSharp";
    Published = new DateTime(2010, 4, 15);
    Tags = new[] { "Mono", "GtkSharp" };

            
            #line default
            #line hidden
WriteLiteral(@"

<p>I ran across this while working on some complex GtkSharp grabbing behavior to mimic window focusing for a docking framework. Turns out there is a weird inconsistency in the way Gtk+ manages the grab stack. While the list of grabbed Widgets is indeed a stack, a flag on each Widget (<code>Widget.HasGrab</code>) is used to check if a Widget has the grab or not. The problem is that <code>Grab.Add</code> (which calls the Gtk+ method <code><a");

WriteLiteral(" href=\"http://library.gnome.org/devel/gtk/stable/gtk-General.html#gtk-grab-add\"");

WriteLiteral(@">gtk_grab_add</a></code>) never clears the flag for the currently grabbed Widget if you're nesting grabs. That means that <em>every Widget in the grab stack</em> will have <code>Widget.HasGrab</code> set to true. If you try to add a Widget to the grab stack and it's already in the stack (even if there are multiple other grabbed Widgets after it in the stack), it won't get added. Because the flag is set though, it <em>will</em> get removed at the first place it was in the stack on a call to <code>Grab.Remove</code> (<code><a");

WriteLiteral(" href=\"http://library.gnome.org/devel/gtk/stable/gtk-General.html#gtk-grab-remove" +
"\"");

WriteLiteral(@">gtk_grab_remove</a></code>).</p>

<p>While it may not be a bug, this is certainly odd behavior. The solution (at least for me) was to write two small utility methods. <code>SafeAdd</code> first removes the <code>Widget.HasGrab</code> flag to ensure that the Widget always gets added to the grab stack, regardless of if it's previously in it. <code>SafeAdd</code> should be paired with <code>SafeRemove</code> which checks the newly grabbed Widget after removing one to make sure it still has the <code>Widget.HasGrab</code> flag set. Note that it doesn't clear the <code>Widget.HasGrab</code> flag for grabbed Widget getting replaced by a new grabbed Widget on the grab stack as you might expect. This maintains compatibility with all the other Gtk code that might be expecting Widgets anywhere in the stack to have the flag set.</p>

<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(@">public static void SafeAdd(Widget widget)
{
 if (widget == null)
 {
  throw new ArgumentNullException(""widget"");
 }
 if (widget.Sensitive)
 {
  widget.ClearFlag(WidgetFlags.HasGrab);
  Grab.Add(widget);
 }
}

public static void SafeRemove(Widget widget)
{
 if (widget == null)
 {
  throw new ArgumentNullException(""widget"");
 }
 Grab.Remove(widget);
 Widget current = Grab.Current;
 if( current != null && !current.HasGrab )
 {
  current.SetFlag(WidgetFlags.HasGrab);
 }
}</code></pre>
");

        }
    }
}
#pragma warning restore 1591
