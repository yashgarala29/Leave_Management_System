#pragma checksum "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\HomePageHOD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d894c27dbf36e5d1e65f9381bdbbe42ff4a19ad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HOD_HomePageHOD), @"mvc.1.0.view", @"/Views/HOD/HomePageHOD.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d894c27dbf36e5d1e65f9381bdbbe42ff4a19ad0", @"/Views/HOD/HomePageHOD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_HOD_HomePageHOD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management_System.Models.ViewModel.HomePageDatapass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
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
                    Home Page HOD



                </h2>
                <div id=""piechart""></div>
            </div>
        </div>




        <!-- column -->

    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        // Load google charts
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        // Draw the chart and set the chart values
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Task', 'Leave Chart'],
                ['Accepted Leave', ");
#nullable restore
#line 39 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                              Write(Model.approveleave);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n                [\'Rejected Leave\', ");
#nullable restore
#line 40 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                              Write(Model.Rejectedleave);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n                [\'Pending  Leave\',");
#nullable restore
#line 41 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                             Write(Model.Peandingeave);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],

            ]);

            // Optional; add a title and set the width and height of the chart
            var options = { 'title': 'Under Employee', 'width': 550, 'height': 400 };

            // Display the chart inside the <div> element with id=""piechart""
            var chart = new google.visualization.PieChart(document.getElementById('piechart'));
            chart.draw(data, options);
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Leave_Management_System.Models.ViewModel.HomePageDatapass> Html { get; private set; }
    }
}
#pragma warning restore 1591
