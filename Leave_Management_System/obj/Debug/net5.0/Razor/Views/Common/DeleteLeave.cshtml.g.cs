#pragma checksum "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e99afb53d2c32722f0812361b85a8cb0f0f2ce32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_DeleteLeave), @"mvc.1.0.view", @"/Views/Common/DeleteLeave.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e99afb53d2c32722f0812361b85a8cb0f0f2ce32", @"/Views/Common/DeleteLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_DeleteLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management_System.Models.ViewModel.DeleteLeave>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
  
    ViewData["Title"] = "DeleteLeave";
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
                    Edit Leave
                </h2>
            </div>
        </div>




        <!-- column -->
        <div class="".col-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <!-- title -->
                    <div class="" align-items-center"">
                        <div>
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    ");
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                   \n                                                                ");
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                                                           Write(Html.DisplayFor(model => model.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                            </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 41 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 44 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 47 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveStartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayFor(model => model.LeaveStartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 53 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveEndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 56 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayFor(model => model.LeaveEndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 62 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
                               Write(Html.DisplayFor(model => model.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                            </dl>\n\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99afb53d2c32722f0812361b85a8cb0f0f2ce329912", async() => {
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e99afb53d2c32722f0812361b85a8cb0f0f2ce3210200", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 67 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Common\DeleteLeave.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.leave_id);

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
                WriteLiteral("\n                                <h3>Are you sure you want to delete this?</h3>\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Leave_Management_System.Models.ViewModel.DeleteLeave> Html { get; private set; }
    }
}
#pragma warning restore 1591