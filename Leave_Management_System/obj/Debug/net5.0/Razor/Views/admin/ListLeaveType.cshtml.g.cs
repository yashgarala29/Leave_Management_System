#pragma checksum "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b2b291ed06c54cb94dddcd31264c8bcb9a06e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_admin_ListLeaveType), @"mvc.1.0.view", @"/Views/admin/ListLeaveType.cshtml")]
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
#line 1 "D:\SDP Backup\New folder\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SDP Backup\New folder\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SDP Backup\New folder\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b2b291ed06c54cb94dddcd31264c8bcb9a06e2", @"/Views/admin/ListLeaveType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_ListLeaveType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leave_Management_System.Models.Class.leaveType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatLeaveType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-orange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateLeaveType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
  
    ViewData["Title"] = "ListLeaveType";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ListLeaveType</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b2b291ed06c54cb94dddcd31264c8bcb9a06e25008", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
           Write(Html.DisplayNameFor(model => model.noofday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
           Write(Html.DisplayNameFor(model => model.allcatoToAll));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
           Write(Html.DisplayNameFor(model => model.itispersonal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 36 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
               Write(Html.DisplayFor(modelItem => item.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 39 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
               Write(Html.DisplayFor(modelItem => item.noofday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 42 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
               Write(Html.DisplayFor(modelItem => item.allcatoToAll));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 45 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
               Write(Html.DisplayFor(modelItem => item.itispersonal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b2b291ed06c54cb94dddcd31264c8bcb9a06e29260", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
                                                                             WriteLiteral(item.leaveTypeID);

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
            WriteLiteral(" |\n                    <a");
            BeginWriteAttribute("id", "  id=\"", 1438, "\"", 1461, 1);
#nullable restore
#line 49 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
WriteAttributeValue("", 1444, item.leaveTypeID, 1444, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Delete\" class=\"btn btn-danger\">Delete</a>\n");
#nullable restore
#line 50 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
                     if (!item.allcatoToAll)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("id", "  id=\"", 1604, "\"", 1627, 1);
#nullable restore
#line 52 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
WriteAttributeValue("", 1610, item.leaveTypeID, 1610, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Allocate\">Allocate to all</a>\n");
#nullable restore
#line 53 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 57 "D:\SDP Backup\New folder\Leave_Management_System\Views\admin\ListLeaveType.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $(""[name=Allocate]"").on(""click"", function () {
            var id = this.id;
            alert(""id=""+id);
            var save_change = ""Accept"";
            $.ajax({
                type: ""POST"",
                url: ""/admin/AllocattoAll"",
                data: { ""id"": id },
                success: function (response) {
                   //alert(""Status Updated Successfully!"");
                    location.reload();

                },
                failure: function (response) {
                    alert(""failure"");
                },
                error: function (response) {
                    alert(""error"");
                }
            });
            //alert(save_change);

        })
        $(""[name=Delete]"").on(""click"", function () {
            var deleteid = this.id;
           // alert(""id="" + deleteid);
            var retVal = confirm(""Do you want to Delete this leave Type ?"");
            if (retVal == true) {
                $.ajax({
                type: ""POST"",");
                WriteLiteral(@"
                url: ""/admin/Delete"",
                data: { ""id"": deleteid },
                success: function (response) {
                   // alert(""Status Updated Successfully!"");
                    location.reload();

                },
                failure: function (response) {
                    alert(""failure"");
                },
                error: function (response) {
                    alert(""error"");
                }
            });

            } else {

                return false;
            }
            
            //alert(save_change);

        })</script>


    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leave_Management_System.Models.Class.leaveType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
