#pragma checksum "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8f4e116a7faa71f4ca59fc8a03137dacff8a84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registrar_ListOfLeaveRequest), @"mvc.1.0.view", @"/Views/Registrar/ListOfLeaveRequest.cshtml")]
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
#line 1 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8f4e116a7faa71f4ca59fc8a03137dacff8a84", @"/Views/Registrar/ListOfLeaveRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Registrar_ListOfLeaveRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Username</th>
            <th>Start Frome</th>
            <th>End Till</th>
            <th>No Of Day</th>
            <th>Status</th>
            <th>Leave Reason</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td> ");
#nullable restore
#line 26 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                Write(Model[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
               Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> ");
#nullable restore
#line 28 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                Write(Model[i].username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
               Write(Model[i].LeaveStartFrome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
               Write(Model[i].LeaveEndTill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> ");
#nullable restore
#line 31 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                Write(Model[i].NoOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"drop\">\n                    <select name=\"status\" class=\"status\" >\n");
#nullable restore
#line 34 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                         foreach (var item in Model[i].Status)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f8f4e116a7faa71f4ca59fc8a03137dacff8a846614", async() => {
#nullable restore
#line 36 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                                             Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                               WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 37 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\n                </td>\n                <td> ");
#nullable restore
#line 40 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
                Write(Model[i].LeaveReason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td> <button class=\"btn btn-primary\"");
            BeginWriteAttribute("value", " value=\"", 1243, "\"", 1263, 1);
#nullable restore
#line 41 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 1251, Model[i].id, 1251, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"savechange\"> Save Change </button></td>\n            </tr>\n");
#nullable restore
#line 43 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Registrar\ListOfLeaveRequest.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
       
        $(""[name=savechange]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = $(this).closest('td').prev().prev().find('.status').val();
            $.ajax({
                type: ""POST"",
                url: ""/Registrar/AjaxMethod"",
                data: { ""name"": save_change,""leave_id"":savechangevalue },
                success: function (response) {
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
    </script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>> Html { get; private set; }
    }
}
#pragma warning restore 1591
