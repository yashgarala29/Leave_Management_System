#pragma checksum "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f5339786abe4ee04e1d78579126e7a08350551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HOD_ListOfLeaveRequest), @"mvc.1.0.view", @"/Views/HOD/ListOfLeaveRequest.cshtml")]
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
#line 1 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f5339786abe4ee04e1d78579126e7a08350551", @"/Views/HOD/ListOfLeaveRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_HOD_ListOfLeaveRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
  

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
                    My Leave Faculty
                </h2>

            </div>
        </div>




        <!-- column -->
        <div class=""col-md-12 mt-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <!-- title -->
                    <div class=""d-md-flex align-items-center"">
                        <div>

                            <h5 class=""card-subtitle"">List Of All Leave Requests</h5>
                        </div>
                        <!--
                        <div class=""ml-auto"">
                            <div class=""dl"">
                                <select class=""custom-select"">
                                    <option value=""0"" selec");
            WriteLiteral(@"ted="""">Monthly</option>
                                    <option value=""1"">Daily</option>
                                    <option value=""2"">Weekly</option>
                                    <option value=""3"">Yearly</option>
                                </select>
                            </div>
                        </div>
                            -->
                    </div>
                    <!-- title -->
                </div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                                <th>Start Frome</th>
                                <th>End Till</th>
                                <th>No Of Day</th>
                                <th>Leave Reason</th>
                                <th>Attachment</th>");
            WriteLiteral("\n                                <th>Operation</th>\n                            </tr>\n                        </thead>\n                        <tbody>\n");
#nullable restore
#line 67 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                             for (int i = 0; i < Model.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td> ");
#nullable restore
#line 70 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 71 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                               Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 72 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 73 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                               Write(Model[i].LeaveStartFrome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 74 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                               Write(Model[i].LeaveEndTill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td> ");
#nullable restore
#line 75 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].NoOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n                                <td> ");
#nullable restore
#line 78 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].LeaveReason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 80 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                     if (Model[i].Attachment==null)
                                    {

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f5339786abe4ee04e1d78579126e7a0835055110109", async() => {
                WriteLiteral("User Document");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3210, "~/file/", 3210, 7, true);
#nullable restore
#line 86 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
AddHtmlAttributeValue("", 3217, Model[i].Attachment, 3217, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                \n                                <!--<td> <button class=\"btn btn-primary\" value=\"");
#nullable restore
#line 91 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                                                           Write(Model[i].id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"savechange\"> Save Change </button></td>-->\n\n                                <td><button class=\"btn btn-success\"");
            BeginWriteAttribute("value", " value=\"", 3579, "\"", 3599, 1);
#nullable restore
#line 93 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 3587, Model[i].id, 3587, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Accept\">Accept</button>\n                                <button class=\"btn btn-danger\"");
            BeginWriteAttribute("value", " value=\"", 3693, "\"", 3713, 1);
#nullable restore
#line 94 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 3701, Model[i].id, 3701, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Reject\">Reject</button></td>\n                                <td></td>\n                            </tr>\n");
#nullable restore
#line 97 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

       /* $(""[name=savechange]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = $(this).closest('td').prev().prev().find('.status').val();
            $.ajax({
                type: ""POST"",
                url: ""/HOD/AjaxMethod"",
                data: { ""name"": save_change, ""leave_id"": savechangevalue },
                success: function (response) {
                    alert(""Status Updated Successfully!"");
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

        })*/

        $(""[name=Accept]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = ""Accepted"";
            $.ajax({
                type: ""POST"",
                u");
                WriteLiteral(@"rl: ""/HOD/AjaxMethod"",
                data: { ""name"": save_change, ""leave_id"": savechangevalue },
                success: function (response) {
                    alert(""Status Updated Successfully!"");
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
        $(""[name=Reject]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = ""Rejected"";
            $.ajax({
                type: ""POST"",
                url: ""/HOD/AjaxMethod"",
                data: { ""name"": save_change, ""leave_id"": savechangevalue },
                success: function (response) {
                    alert(""Status Updated Successfully!"");
                    location.reload();

                },
                fai");
                WriteLiteral(@"lure: function (response) {
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
