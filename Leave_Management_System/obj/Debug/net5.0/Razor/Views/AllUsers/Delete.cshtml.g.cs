#pragma checksum "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d925a2aa5b944e323e7ebdc24a0d65aa91e4468d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllUsers_Delete), @"mvc.1.0.view", @"/Views/AllUsers/Delete.cshtml")]
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
#line 1 "D:\Project Copy\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Copy\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project Copy\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d925a2aa5b944e323e7ebdc24a0d65aa91e4468d", @"/Views/AllUsers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_AllUsers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management_System.Models.Class.AllUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Begin Page Content -->
<div class=""container-fluid px-lg-4"">
    <div class=""row"">
        <div class=""col-md-12 mt-lg-4 mt-4"">
            <!-- Page Heading -->
            <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
                <h2 class=""h3 mb-0 text-black-50 "">
                   Delete User Details
                </h2>
            </div>
        </div>




        <!-- column -->
        <div class=""col-sm-8"">
            <div class=""card"">
                <div class=""card-body"">
                    <!-- title -->
                    <div class="" align-items-center"">
                        <div>
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    ");
#nullable restore
#line 34 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 37 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 40 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.MobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 43 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.MobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 46 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.MobileNo2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 49 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.MobileNo2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 52 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 55 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 58 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 61 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 64 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 67 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 70 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Deparment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 73 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Deparment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 76 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 79 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 82 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Addreaddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 85 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Addreaddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 88 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 91 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 94 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.PaidLeave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 97 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.PaidLeave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                            </dl>\n\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d925a2aa5b944e323e7ebdc24a0d65aa91e4468d14395", async() => {
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d925a2aa5b944e323e7ebdc24a0d65aa91e4468d14684", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 102 "D:\Project Copy\Leave_Management_System\Views\AllUsers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <h3>Are you sure you want to delete this?</h3>\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d925a2aa5b944e323e7ebdc24a0d65aa91e4468d16585", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n\n                    </div>\n                    <!-- title -->\n                </div>\n\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Leave_Management_System.Models.Class.AllUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
