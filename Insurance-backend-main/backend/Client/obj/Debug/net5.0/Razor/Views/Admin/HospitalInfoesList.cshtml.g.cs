#pragma checksum "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "145e4f9ad3b6b8585ce0658c275a2372beab3a23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_HospitalInfoesList), @"mvc.1.0.view", @"/Views/Admin/HospitalInfoesList.cshtml")]
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
#line 1 "D:\Clone\Insurance-backend\backend\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Clone\Insurance-backend\backend\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145e4f9ad3b6b8585ce0658c275a2372beab3a23", @"/Views/Admin/HospitalInfoesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_HospitalInfoesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Client.Models.HospitalInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/_NavbarAdmin.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddHp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HospitalInfoesList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "145e4f9ad3b6b8585ce0658c275a2372beab3a235384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""content-wrapper"">
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Hospital</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item active"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145e4f9ad3b6b8585ce0658c275a2372beab3a236951", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <div class=""row"">
        <div class=""col-5"">
            <div class=""p-2 form-search"">
                <div class=""search-hp"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145e4f9ad3b6b8585ce0658c275a2372beab3a238689", async() => {
                WriteLiteral(@"
                        <p class=""search-title"">Search Name Hospital</p>
                        <input type=""text"" name=""searchname"" class=""search""/>
                        <button type=""submit"" class=""btn-search""><i class=""fas fa-search fa-fw""></i></button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <section class=""content"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">Hospital</h3>
                <div class=""card-tools"">
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                        <i class=""fas fa-minus""></i>
                    </button>
                </div>
            </div>
            <div class=""card-body p-0"">
                <table class=""table table-striped projects"">
                    <thead>
                        <tr>
                            <th>
                                #
                            </th>
                            <th>
                                HospitalName
                            </th>
                            <th>
                                Phone
                            </th>
                            ");
            WriteLiteral(@"<th>
                                Address
                            </th>
                            <th>
                                Url
                            </th>
                            <th style=""width: 15%"" class=""text-center"">
                                Acction
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 68 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                         if (Model != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-left\">\r\n                                        ");
#nullable restore
#line 74 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-left\">\r\n                                        ");
#nullable restore
#line 77 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                                   Write(item.HospitalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"project_progress\">\r\n                                        ");
#nullable restore
#line 80 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"project-state text-left\">\r\n                                        ");
#nullable restore
#line 83 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"project-state text-left\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3663, "\"", 3692, 3);
            WriteAttributeValue("", 3670, "https://www.", 3670, 12, true);
#nullable restore
#line 86 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
WriteAttributeValue("", 3682, item.Url, 3682, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3691, "/", 3691, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                                                                    Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </td>\r\n                                    <td class=\"project-actions text-left\">\r\n                                        <a class=\"btn btn-primary btn-sm \"");
            BeginWriteAttribute("href", " href=\"", 3902, "\"", 3933, 2);
            WriteAttributeValue("", 3909, "/Admin/HpDetail/", 3909, 16, true);
#nullable restore
#line 89 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
WriteAttributeValue("", 3925, item.Id, 3925, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fas fa-eye"">
                                            </i>
                                            View
                                        </a>
                                        <a class=""btn btn-info btn-sm""");
            BeginWriteAttribute("href", " href=\"", 4221, "\"", 4250, 2);
            WriteAttributeValue("", 4228, "/Admin/EditHp/", 4228, 14, true);
#nullable restore
#line 94 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
WriteAttributeValue("", 4242, item.Id, 4242, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fas fa-pencil-alt"">
                                            </i>
                                            Edit
                                        </a>
                                        <a class=""btn btn-danger btn-sm""");
            BeginWriteAttribute("href", " href=\"", 4547, "\"", 4575, 2);
            WriteAttributeValue("", 4554, "/Admin/DelHp/", 4554, 13, true);
#nullable restore
#line 99 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
WriteAttributeValue("", 4567, item.Id, 4567, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fas fa-trash"">
                                            </i>
                                            Delete
                                        </a>
                                    </td>
                                </tr>
");
#nullable restore
#line 106 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\Clone\Insurance-backend\backend\Client\Views\Admin\HospitalInfoesList.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Client.Models.HospitalInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
