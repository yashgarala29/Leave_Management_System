#pragma checksum "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8685eafd67c0c39c31ed9e26630519f92ba4532e"
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
#line 1 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8685eafd67c0c39c31ed9e26630519f92ba4532e", @"/Views/HOD/ListOfLeaveRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee516de2d55a90bd3e2f8df69648b9fe6a4b048", @"/Views/_ViewImports.cshtml")]
    public class Views_HOD_ListOfLeaveRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
  

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
                          ");
            WriteLiteral(@"          <option value=""0"" selected="""">Monthly</option>
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
                                <th>Leave Reason</t");
            WriteLiteral("h>\r\n                                <th>Operation</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 66 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                             for (int i = 0; i < Model.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 69 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                               Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 71 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                               Write(Model[i].LeaveStartFrome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                               Write(Model[i].LeaveEndTill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 74 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].NoOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                <td> ");
#nullable restore
#line 77 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                Write(Model[i].LeaveReason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <!--<td> <button class=\"btn btn-primary\" value=\"");
#nullable restore
#line 78 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                                                           Write(Model[i].id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"savechange\"> Save Change </button></td>-->\r\n\r\n                                <td><button class=\"btn btn-success\"");
            BeginWriteAttribute("value", " value=\"", 3136, "\"", 3156, 1);
#nullable restore
#line 80 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 3144, Model[i].id, 3144, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Accept\">Accept</button>\r\n                                <button class=\"btn btn-danger\"");
            BeginWriteAttribute("value", " value=\"", 3251, "\"", 3271, 1);
#nullable restore
#line 81 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 3259, Model[i].id, 3259, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Reject\">Reject</button></td>\r\n                                <td></td>\r\n                            </tr>\r\n");
#nullable restore
#line 84 "D:\SDP Backup\2-18-2021\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
            var save_change = ""Accept"";
            $.ajax({
                typ");
                WriteLiteral(@"e: ""POST"",
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

        })
        $(""[name=Reject]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = ""Reject"";
            $.ajax({
                type: ""POST"",
                url: ""/HOD/AjaxMethod"",
                data: { ""name"": save_change, ""leave_id"": savechangevalue },
                success: function (response) {
                    alert(""Status Updated Successfully!"");
                    locat");
                WriteLiteral(@"ion.reload();

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
