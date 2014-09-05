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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Blog/Posts/quick-and-dirty-multiple-value-dictionary-using-extension-meth" +
        "ods.cshtml")]
    public partial class quick_and_dirty_multiple_value_dictionary_using_extension_methods : Somedave.BlogPostViewPage<dynamic>
    {
        public quick_and_dirty_multiple_value_dictionary_using_extension_methods()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Blog\Posts\quick-and-dirty-multiple-value-dictionary-using-extension-methods.cshtml"
  
    Title = "Quick and Dirty Multiple Value Dictionary Using Extension Methods";
    Published = new DateTime(2013, 5, 16);
    Tags = new[] { "DotNet", "CSharp", "Dictionary", "MultiDictionary" };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<p>Though it\'s not a collection I tend to reach for often, there have been ti" +
"mes when I really need a multiple value dictionary (that is, a dictionary that c" +
"ontains more than one value per key). In the past, I\'ve usually reached for the " +
"excellent <a");

WriteLiteral(" href=\"http://powercollections.codeplex.com/\"");

WriteLiteral(@">PowerCollections</a> library to fill the gap. However, that requires bringing in another library and it can be a little heavy-weight for just this one collection class. There are also a ton of other implementations out there. But perhaps there's a better way to fill this need, one that doesn't require a lot of extra code. These two extension methods do most of the work of a multiple value dictionary, but don't require any extra classes or libraries:</p>

<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(@">public static void AddMulti&lt;TKey, TCollection, TValue&gt;(
    this IDictionary&lt;TKey, TCollection&gt; dictionary, TKey key, TValue value)
    where TCollection : ICollection&lt;TValue&gt;, new()
{
    TCollection collection;
    if (!dictionary.TryGetValue(key, out collection))
    {
        collection = new TCollection();
        dictionary.Add(key, collection);
    }
    collection.Add(value);
}

public static bool ContainsMultiValue&lt;TKey, TCollection, TValue&gt;(
    this IDictionary&lt;TKey, TCollection&gt; dictionary, TKey key, TValue value)
    where TCollection : ICollection&lt;TValue&gt;, new()
{
    TCollection collection;
    return dictionary.TryGetValue(key, out collection) &amp;&amp; collection.Contains(value);
}</code></pre>

<p>The extensions apply to any IDictionary&lt;TKey, TCollection&gt; where TCollection implements ICollection&lt;TValue&gt;. The idea is that you bring your own dictionary with an arbitrary collection for values and the extension manages adding a new collection when the key doesn't exist and adding a value to the collection for a given key. The nice this is that by varying the type of collection you can get different behavior. Use a <code>List&lt;TValue&gt;</code> when you want duplicate values to be allowed and a <code>HashSet&lt;TValue&gt;</code> when you don't. Here's an example:</p>

<pre><code");

WriteLiteral(" class=\"language-csharp\"");

WriteLiteral(@">Dictionary&lt;string, List&lt;int&gt;&gt; duplicateValuesDictionary
  = new Dictionary&lt;string, List&lt;int&gt;&gt;();
duplicateValuesDictionary.AddMulti(""foo"", 1);
duplicateValuesDictionary.AddMulti(""foo"", 1);
duplicateValuesDictionary.AddMulti(""foo"", 2);
duplicateValuesDictionary.ContainsMultiValue(1);  // True
duplicateValuesDictionary[""foo""].Contains(1);     // True
duplicateValuesDictionary.ContainsMultiValue(3);  // False

Dictionary&lt;string, HashSet&lt;int&gt;&gt; uniqueValuesDictionary
  = new Dictionary&lt;string, HashSet&lt;int&gt;&gt;();
uniqueValuesDictionary.AddMulti(""foo"", 1);
uniqueValuesDictionary.AddMulti(""foo"", 1);  // This is throw an exception</code></pre>

<p>Obviously this approach won't work in all cases. For example, you don't have a lot of control over the comparer or construction logic that the inner <code>ICollection&lt;TValue&gt;</code> uses since it gets constructed using the general <code>new()</code> statement. But in general, this can be a good lightweight way to add multiple value dictionary support without the overhead of an additional library.</p>
");

        }
    }
}
#pragma warning restore 1591
