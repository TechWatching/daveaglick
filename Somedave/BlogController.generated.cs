// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Somedave.Controllers
{
    public partial class BlogController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BlogController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected BlogController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Posts()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Posts);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Tags()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tags);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public BlogController Actions { get { return MVC.Blog; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Blog";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Blog";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Posts = "Posts";
            public readonly string Tags = "Tags";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Posts = "Posts";
            public const string Tags = "Tags";
        }


        static readonly ActionParamsClass_Posts s_params_Posts = new ActionParamsClass_Posts();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Posts PostsParams { get { return s_params_Posts; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Posts
        {
            public readonly string viewName = "viewName";
        }
        static readonly ActionParamsClass_Tags s_params_Tags = new ActionParamsClass_Tags();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Tags TagsParams { get { return s_params_Tags; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Tags
        {
            public readonly string tag = "tag";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Archive = "Archive";
                public readonly string Tags = "Tags";
            }
            public readonly string Archive = "~/Views/Blog/Archive.cshtml";
            public readonly string Tags = "~/Views/Blog/Tags.cshtml";
            static readonly _PostsClass s_Posts = new _PostsClass();
            public _PostsClass Posts { get { return s_Posts; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _PostsClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string _Layout = "_Layout";
                    public readonly string _ViewStart = "_ViewStart";
                    public readonly string a_survey_of_dotnet_static_site_generators = "a-survey-of-dotnet-static-site-generators";
                    public readonly string a_t4_template_to_get_all_css_class_names = "a-t4-template-to-get-all-css-class-names";
                    public readonly string a_tale_of_two_apis = "a-tale-of-two-apis";
                    public readonly string announcing_linqpad_codeanalysis = "announcing-linqpad-codeanalysis";
                    public readonly string announcing_razordatabase = "announcing-razordatabase";
                    public readonly string automatic_retry_for_linq_to_sql = "automatic-retry-for-linq-to-sql";
                    public readonly string automatically_generating_column_titles_for_a_kendoui_mvc_grid = "automatically-generating-column-titles-for-a-kendoui-mvc-grid";
                    public readonly string brace_style_convention = "brace-style-convention";
                    public readonly string compiler_platform_scripting = "compiler-platform-scripting";
                    public readonly string computed_properties_and_entity_framework = "computed-properties-and-entity-framework";
                    public readonly string custom_entity_type_configurations_in_entity_framework_code_first_part_1 = "custom-entity-type-configurations-in-entity-framework-code-first-part-1";
                    public readonly string custom_entity_type_configurations_in_entity_framework_code_first_part_2 = "custom-entity-type-configurations-in-entity-framework-code-first-part-2";
                    public readonly string debugging_stack_overflows_on_iis = "debugging-stack-overflows-on-iis";
                    public readonly string deploying_a_public_nuget_package_from_scratch = "deploying-a-public-nuget-package-from-scratch";
                    public readonly string eliminating_magic_strings = "eliminating-magic-strings";
                    public readonly string exporting_a_gtksharp_treeview_to_csv = "exporting-a-gtksharp-treeview-to-csv";
                    public readonly string fun_with_fizz_buzz = "fun-with-fizz-buzz";
                    public readonly string getting_an_htmlhelper_for_an_alternate_model_type = "getting-an-htmlhelper-for-an-alternate-model-type";
                    public readonly string how_i_export_kendo_grids_to_excel_or_csv = "how-i-export-kendo-grids-to-excel-or-csv";
                    public readonly string how_to_post_data_in_a_kendoui_grid = "how-to-post-data-in-a-kendoui-grid";
                    public readonly string how_to_value_creative_work_in_the_new_economy = "how-to-value-creative-work-in-the-new-economy";
                    public readonly string introducing_fluentbootstrap = "introducing-fluentbootstrap";
                    public readonly string introducing_nicethreads = "introducing-nicethreads";
                    public readonly string introducing_nxdb = "introducing-nxdb";
                    public readonly string method_chaining_fluent_interfaces_and_the_finishing_problem = "method-chaining-fluent-interfaces-and-the-finishing-problem";
                    public readonly string nested_grabs_in_gtksharp = "nested-grabs-in-gtksharp";
                    public readonly string new_blog = "new-blog";
                    public readonly string object_persistence_in_nxdb = "object-persistence-in-nxdb";
                    public readonly string open_source_obligations = "open-source-obligations";
                    public readonly string quick_and_dirty_multiple_value_dictionary_using_extension_methods = "quick-and-dirty-multiple-value-dictionary-using-extension-methods";
                    public readonly string random_polygon_page_backgrounds = "random-polygon-page-backgrounds";
                    public readonly string right_click_context_menus_in_gtksharp = "right-click-context-menus-in-gtksharp";
                    public readonly string round_robin_row_selection_from_sql_server = "round-robin-row-selection-from-sql-server";
                    public readonly string simple_row_coloring_in_kendo_grid = "simple-row-coloring-in-kendo-grid";
                    public readonly string strongly_typed_icon_fonts_in_aspnet_mvc = "strongly-typed-icon-fonts-in-aspnet-mvc";
                    public readonly string using_aspnet_mvc_and_razor_to_generate_pdf_files = "using-aspnet-mvc-and-razor-to-generate-pdf-files";
                    public readonly string Web = "Web";
                    public readonly string xquery_function_to_get_the_number_of_week_work_days = "xquery-function-to-get-the-number-of-week-work-days";
                }
                public readonly string _Layout = "~/Views/Blog/Posts/_Layout.cshtml";
                public readonly string _ViewStart = "~/Views/Blog/Posts/_ViewStart.cshtml";
                public readonly string a_survey_of_dotnet_static_site_generators = "~/Views/Blog/Posts/a-survey-of-dotnet-static-site-generators.cshtml";
                public readonly string a_t4_template_to_get_all_css_class_names = "~/Views/Blog/Posts/a-t4-template-to-get-all-css-class-names.cshtml";
                public readonly string a_tale_of_two_apis = "~/Views/Blog/Posts/a-tale-of-two-apis.cshtml";
                public readonly string announcing_linqpad_codeanalysis = "~/Views/Blog/Posts/announcing-linqpad-codeanalysis.cshtml";
                public readonly string announcing_razordatabase = "~/Views/Blog/Posts/announcing-razordatabase.cshtml";
                public readonly string automatic_retry_for_linq_to_sql = "~/Views/Blog/Posts/automatic-retry-for-linq-to-sql.cshtml";
                public readonly string automatically_generating_column_titles_for_a_kendoui_mvc_grid = "~/Views/Blog/Posts/automatically-generating-column-titles-for-a-kendoui-mvc-grid.cshtml";
                public readonly string brace_style_convention = "~/Views/Blog/Posts/brace-style-convention.cshtml";
                public readonly string compiler_platform_scripting = "~/Views/Blog/Posts/compiler-platform-scripting.cshtml";
                public readonly string computed_properties_and_entity_framework = "~/Views/Blog/Posts/computed-properties-and-entity-framework.cshtml";
                public readonly string custom_entity_type_configurations_in_entity_framework_code_first_part_1 = "~/Views/Blog/Posts/custom-entity-type-configurations-in-entity-framework-code-first-part-1.cshtml";
                public readonly string custom_entity_type_configurations_in_entity_framework_code_first_part_2 = "~/Views/Blog/Posts/custom-entity-type-configurations-in-entity-framework-code-first-part-2.cshtml";
                public readonly string debugging_stack_overflows_on_iis = "~/Views/Blog/Posts/debugging-stack-overflows-on-iis.cshtml";
                public readonly string deploying_a_public_nuget_package_from_scratch = "~/Views/Blog/Posts/deploying-a-public-nuget-package-from-scratch.cshtml";
                public readonly string eliminating_magic_strings = "~/Views/Blog/Posts/eliminating-magic-strings.cshtml";
                public readonly string exporting_a_gtksharp_treeview_to_csv = "~/Views/Blog/Posts/exporting-a-gtksharp-treeview-to-csv.cshtml";
                public readonly string fun_with_fizz_buzz = "~/Views/Blog/Posts/fun-with-fizz-buzz.cshtml";
                public readonly string getting_an_htmlhelper_for_an_alternate_model_type = "~/Views/Blog/Posts/getting-an-htmlhelper-for-an-alternate-model-type.cshtml";
                public readonly string how_i_export_kendo_grids_to_excel_or_csv = "~/Views/Blog/Posts/how-i-export-kendo-grids-to-excel-or-csv.cshtml";
                public readonly string how_to_post_data_in_a_kendoui_grid = "~/Views/Blog/Posts/how-to-post-data-in-a-kendoui-grid.cshtml";
                public readonly string how_to_value_creative_work_in_the_new_economy = "~/Views/Blog/Posts/how-to-value-creative-work-in-the-new-economy.cshtml";
                public readonly string introducing_fluentbootstrap = "~/Views/Blog/Posts/introducing-fluentbootstrap.cshtml";
                public readonly string introducing_nicethreads = "~/Views/Blog/Posts/introducing-nicethreads.cshtml";
                public readonly string introducing_nxdb = "~/Views/Blog/Posts/introducing-nxdb.cshtml";
                public readonly string method_chaining_fluent_interfaces_and_the_finishing_problem = "~/Views/Blog/Posts/method-chaining-fluent-interfaces-and-the-finishing-problem.cshtml";
                public readonly string nested_grabs_in_gtksharp = "~/Views/Blog/Posts/nested-grabs-in-gtksharp.cshtml";
                public readonly string new_blog = "~/Views/Blog/Posts/new-blog.cshtml";
                public readonly string object_persistence_in_nxdb = "~/Views/Blog/Posts/object-persistence-in-nxdb.cshtml";
                public readonly string open_source_obligations = "~/Views/Blog/Posts/open-source-obligations.cshtml";
                public readonly string quick_and_dirty_multiple_value_dictionary_using_extension_methods = "~/Views/Blog/Posts/quick-and-dirty-multiple-value-dictionary-using-extension-methods.cshtml";
                public readonly string random_polygon_page_backgrounds = "~/Views/Blog/Posts/random-polygon-page-backgrounds.cshtml";
                public readonly string right_click_context_menus_in_gtksharp = "~/Views/Blog/Posts/right-click-context-menus-in-gtksharp.cshtml";
                public readonly string round_robin_row_selection_from_sql_server = "~/Views/Blog/Posts/round-robin-row-selection-from-sql-server.cshtml";
                public readonly string simple_row_coloring_in_kendo_grid = "~/Views/Blog/Posts/simple-row-coloring-in-kendo-grid.cshtml";
                public readonly string strongly_typed_icon_fonts_in_aspnet_mvc = "~/Views/Blog/Posts/strongly-typed-icon-fonts-in-aspnet-mvc.cshtml";
                public readonly string using_aspnet_mvc_and_razor_to_generate_pdf_files = "~/Views/Blog/Posts/using-aspnet-mvc-and-razor-to-generate-pdf-files.cshtml";
                public readonly string Web = "~/Views/Blog/Posts/Web.config";
                public readonly string xquery_function_to_get_the_number_of_week_work_days = "~/Views/Blog/Posts/xquery-function-to-get-the-number-of-week-work-days.cshtml";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_BlogController : Somedave.Controllers.BlogController
    {
        public T4MVC_BlogController() : base(Dummy.Instance) { }

        [NonAction]
        partial void PostsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string viewName);

        [NonAction]
        public override System.Web.Mvc.ActionResult Posts(string viewName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Posts);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewName", viewName);
            PostsOverride(callInfo, viewName);
            return callInfo;
        }

        [NonAction]
        partial void TagsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string tag);

        [NonAction]
        public override System.Web.Mvc.ActionResult Tags(string tag)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Tags);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "tag", tag);
            TagsOverride(callInfo, tag);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
