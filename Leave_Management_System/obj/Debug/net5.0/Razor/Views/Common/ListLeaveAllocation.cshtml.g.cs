#pragma checksum "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c75a13b66b86e95a877917aa79c9c16dbf55b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_ListLeaveAllocation), @"mvc.1.0.view", @"/Views/Common/ListLeaveAllocation.cshtml")]
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
#line 1 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c75a13b66b86e95a877917aa79c9c16dbf55b7b", @"/Views/Common/ListLeaveAllocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_ListLeaveAllocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leave_Management_System.Models.Class.LeaveAllocation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-orange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
   ViewData["Title"] = "ListLeaveAllocation";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Begin Page Content -->
<div class=""container-fluid px-lg-4"">
    <div class=""row justify-content-center"">
        <div class=""col-md-12 mt-lg-4 mt-4"">
            <!-- Page Heading -->
            <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
                <h2 class=""h3 mb-0 text-black-50 "">
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

                            <h1>ListLeaveAllocation</h1>

                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>
                                            ");
#nullable restore
#line 33 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                                       Write(Html.DisplayNameFor(model => model.NoOfLeave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </th>\n                                        <th>\n                                            ");
#nullable restore
#line 36 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                                       Write(Html.DisplayNameFor(model => model.AllUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </th>\n                                        <th>\n                                            ");
#nullable restore
#line 39 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                                       Write(Html.DisplayNameFor(model => model.leaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </th>\n                                        <th></th>\n                                    </tr>\n                                </thead>\n                                <tbody>\n");
#nullable restore
#line 45 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 49 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NoOfLeave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 52 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AllUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 55 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                           Write(Html.DisplayFor(modelItem => item.leaveType.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c75a13b66b86e95a877917aa79c9c16dbf55b7b8691", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
                                                                              WriteLiteral(item.AllocationID);

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
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 61 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\ListLeaveAllocation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>\n                        </div>\n\n                    </div>\n\n                </div>\n\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leave_Management_System.Models.Class.LeaveAllocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
