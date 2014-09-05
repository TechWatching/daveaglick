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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Posts/exporting-a-gtksharp-treeview-to-csv.cshtml")]
    public partial class exporting_a_gtksharp_treeview_to_csv : Somedave.BlogPostViewPage<dynamic>
    {
        public exporting_a_gtksharp_treeview_to_csv()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Blog\Posts\exporting-a-gtksharp-treeview-to-csv.cshtml"
  
    Title = "Exporting a GtkSharp TreeView to CSV";
    Lead = "All packaged up in nice little utility methods.";
    Published = new DateTime(2010, 4, 9);
    Tags = new[] { "Mono", "GtkSharp", "CellRenderer", "CSV", "TreeModel", "TreeView", "TreeViewColumn" };

            
            #line default
            #line hidden
WriteLiteral(@"

<p>I recently had to create some functionality to export a TreeView widget to a CSV file for further analysis. Since I tend to think about generic behavior, I decided to code up a method that would take any arbitrary TreeView and perform the export operation. Luckily, the TreeView widget and the attached TreeModel both contain a lot of functionality for accessing the data and it's presentation. I decided that I wanted the exported CSV file to represent the perspective of the model as currently represented in the TreeView including column visibility and sort order. This led to the trickiest part of the process. Because a CellRenderer can be customized using cell data functions (such as those added by a call to TreeViewColumn.SetCellDataFunc), I had to pull the content to export from the CellRenderer as opposed to pulling directly from the TreeModel. Turns out there's a method to take the TreeIter from a TreeModel and apply it to all the CellRenderers in a given TreeViewColumn. Since I really only care about textual content, I decided to only export those columns that contain CellRendererText renderers.</p>
<p>After working out the algorithm to fetch what needed to be exported I thought I was ready to roll. Turns out that the CSV pseudo-standard is pretty complex though (the RFC is <a");

WriteLiteral(" href=\"http://www.rfc-editor.org/rfc/rfc4180.txt\"");

WriteLiteral(">here</a>), and I quickly got bogged down in writing all kinds of special cases f" +
"or escaping, quoting, etc. Thankfully, someone else had already been down this r" +
"oad and I was able to find the excellent <a");

WriteLiteral(" href=\"http://kbcsv.codeplex.com/\"");

WriteLiteral(@">KBCsv</a> library which will write and read formatted CSV files. My only complaint was that it used another utility library purely for convenience in exception generation and null checking (I already use a ton of libraries in our application and I'd prefer not to add any unnecessarily). I replaced the calls to the utility library with the language equivalents, but that's totally a personal preference.</p>
<p>Without further adieu, I present the <code>TreeViewHelper.ExportToCsv</code> and <code>TreeViewHelper.ExportToCsvFile</code> methods...</p>
<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(">using System;\r\nusing System.Collections.Generic;\r\nusing System.IO;\r\nusing Gtk;\r\n" +
"using Kent.Boogaart.KBCsv;\r\n\r\nnamespace Somedave\r\n{\r\n public static class TreeVi" +
"ewHelper\r\n {\r\n  public static bool ExportToCsv(TreeView treeView, Window parent)" +
"\r\n  {\r\n   FileChooserDialog fcd = new FileChooserDialog(\"Export File\", parent, F" +
"ileChooserAction.Save,\r\n   \"Cancel\", ResponseType.Cancel, \"Export\", ResponseType" +
".Accept);\r\n   fcd.DoOverwriteConfirmation = true;\r\n   FileFilter filter = new Fi" +
"leFilter { Name = \"CSV File\" };\r\n   filter.AddPattern(\"*.csv\");\r\n   fcd.AddFilte" +
"r(filter);\r\n   if (fcd.Run() == (int)ResponseType.Accept)\r\n   {\r\n    string path" +
" = fcd.Filename;\r\n    fcd.Destroy();\r\n    return ExportToCsvFile(treeView, path)" +
";\r\n   }\r\n   fcd.Destroy();\r\n   return false;\r\n  }\r\n\r\n  public static bool Export" +
"ToCsvFile(TreeView treeView, string path)\r\n  {\r\n   //Get the iterator\r\n   TreeIt" +
"er iter;\r\n   if (treeView.Model.GetIterFirst(out iter))\r\n   {\r\n    //Create the " +
"stream\r\n    using (StreamWriter streamWriter = new StreamWriter(path, false))\r\n " +
"   {\r\n     //Create the CSV writer\r\n     using (CsvWriter csvWriter = new CsvWri" +
"ter(streamWriter))\r\n     {\r\n      List&lt;string&gt; headers = new List&lt;strin" +
"g&gt;();\r\n      List&lt;string&gt; values = new List&lt;string&gt;();\r\n\r\n      /" +
"/Traverse the tree\r\n      do\r\n      {\r\n       values.Clear();\r\n       foreach (T" +
"reeViewColumn column in treeView.Columns)\r\n       {\r\n        //Only output visib" +
"le columns\r\n        if (column.Visible)\r\n        {\r\n         //Loop through Cell" +
"Renderers to make sure we have a CellRendererText\r\n         string value = null;" +
"\r\n         column.CellSetCellData(treeView.Model, iter, false, false);\r\n        " +
" foreach (CellRenderer renderer in column.CellRenderers)\r\n         {\r\n          " +
"CellRendererText text = renderer as CellRendererText;\r\n          if (text != nul" +
"l)\r\n          {\r\n           //Setting value indicates this column had a CellRend" +
"ererText and should be included\r\n           if (value == null)\r\n           {\r\n  " +
"          value = String.Empty;\r\n           }\r\n\r\n           //Add the header if " +
"the first time through\r\n           if (headers != null)\r\n           {\r\n         " +
"   headers.Add(column.Title);\r\n           }\r\n\r\n           //Append to the value\r" +
"\n           if (text.Text != null)\r\n           {\r\n            value += text.Text" +
";\r\n           }\r\n          }\r\n         }\r\n         if (value != null)\r\n         " +
"{\r\n          values.Add(value);\r\n         }\r\n        }\r\n       }\r\n\r\n       //Out" +
"put the header\r\n       if (headers != null)\r\n       {\r\n        csvWriter.WriteHe" +
"aderRecord(headers.ToArray());\r\n        headers = null;\r\n       }\r\n\r\n       //Ou" +
"tput the values\r\n       csvWriter.WriteDataRecord(values.ToArray());\r\n      } wh" +
"ile (treeView.Model.IterNext(ref iter));\r\n     }\r\n    }\r\n    return true;\r\n   }\r" +
"\n   return false;\r\n  }\r\n }\r\n}\r\n</code></pre>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
