#pragma checksum "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb9fef2de7a3315bfcebfca51da39815a2b1626e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\_ViewImports.cshtml"
using Asp_MongoDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\_ViewImports.cshtml"
using Asp_MongoDB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb9fef2de7a3315bfcebfca51da39815a2b1626e", @"/Areas/Admin/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2baaa07145010b9497c2f7161c3cd977e3bc0b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp_MongoDB.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-lg-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header row\">\r\n    <div class=\"header-sub-title col-md-12\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9fef2de7a3315bfcebfca51da39815a2b1626e7021", async() => {
                WriteLiteral("\r\n                <i class=\"anticon anticon-home m-r-5\"></i>Home\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9fef2de7a3315bfcebfca51da39815a2b1626e8555", async() => {
                WriteLiteral("\r\n                Orders\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">List Orders</span>\r\n        </nav>\r\n    </div>\r\n    <div class=\"col-md-12\" style=\"display: flex;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9fef2de7a3315bfcebfca51da39815a2b1626e10206", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"sr-only\"");
                BeginWriteAttribute("for", " for=\"", 862, "\"", 868, 0);
                EndWriteAttribute();
                WriteLiteral(">label</label>\r\n                <input class=\"form-control\" name=\"name\" placeholder=\"Search\"");
                BeginWriteAttribute("value", " value=\"", 961, "\"", 988, 1);
#nullable restore
#line 24 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
WriteAttributeValue("", 969, ViewBag.SearchTerm, 969, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-icon btn-default mr-1\"><i class=\"anticon anticon-search\"></i></button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9fef2de7a3315bfcebfca51da39815a2b1626e12679", async() => {
                WriteLiteral("\r\n            <i class=\"anticon anticon-plus btn btn-icon btn-success\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 42 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 48 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 51 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 57 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 70 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 73 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"d-flex\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb9fef2de7a3315bfcebfca51da39815a2b1626e18058", async() => {
                WriteLiteral("\r\n                                <i class=\"anticon anticon-info-circle btn btn-icon btn-primary mr-2\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                                                                       WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
        <hr />
        <div class=""row"">
            <div class=""col-sm-12 col-md-5"">
                <div class=""dataTables_info"">
                    Showing
                    <span class=""text-danger"">
                        ");
#nullable restore
#line 90 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(ViewBag.CurrentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                    of\r\n                    <b>\r\n                        ");
#nullable restore
#line 94 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                   Write(ViewBag.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </b>
                    pages
                </div>
            </div>
            <div class=""col-sm-12 col-md-7"">
                <div class=""float-right "">
                    <ul class=""pagination justify-content-center"">
");
#nullable restore
#line 102 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                         if (ViewBag.CurrentPage > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item \"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4101, "\"", 4152, 2);
            WriteAttributeValue("", 4108, "/Admin/Books?page=", 4108, 18, true);
#nullable restore
#line 104 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4126, ViewBag.CurrentPage - 1, 4126, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Pre</a></li>\r\n");
#nullable restore
#line 105 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 107 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                         for (int i = 1; i <= ViewBag.TotalPages; i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                             if (ViewBag.CurrentPage == i)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4468, "\"", 4495, 2);
            WriteAttributeValue("", 4475, "/Admin/Books?page=", 4475, 18, true);
#nullable restore
#line 111 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4493, i, 4493, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 111 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 112 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4680, "\"", 4707, 2);
            WriteAttributeValue("", 4687, "/Admin/Books?page=", 4687, 18, true);
#nullable restore
#line 115 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4705, i, 4705, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 116 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 119 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                         if (ViewBag.CurrentPage < ViewBag.TotalPages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item \"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4952, "\"", 5003, 2);
            WriteAttributeValue("", 4959, "/Admin/Books?page=", 4959, 18, true);
#nullable restore
#line 121 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4977, ViewBag.CurrentPage + 1, 4977, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a></li>\r\n");
#nullable restore
#line 122 "D:\MongoDB\Asp_MongoDB\Asp_MongoDB\Areas\Admin\Views\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp_MongoDB.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
