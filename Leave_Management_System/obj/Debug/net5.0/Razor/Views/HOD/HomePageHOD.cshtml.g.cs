#pragma checksum "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b43176666545b6c0515f3cd23c573c32d62a33e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b43176666545b6c0515f3cd23c573c32d62a33e", @"/Views/HOD/HomePageHOD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_HOD_HomePageHOD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management_System.Models.ViewModel.HomePageDatapass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6 col-lg-3\">\n        <div class=\"statistic__item\">\n            <h2 class=\"number\"> ");
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                           Write(Model.Peandingeave);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <span class=""desc"">Pending Requests</span>
            <div class=""icon"">
                <i class=""zmdi zmdi-spinner""></i>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""statistic__item"">
            <h2 class=""number""> ");
#nullable restore
#line 16 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                           Write(Model.approveleave);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <span class=""desc"">Accepted Requests</span>
            <div class=""icon"">
                <i class=""zmdi zmdi-badge-check""></i>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""statistic__item"">
            <h2 class=""number"">");
#nullable restore
#line 25 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                          Write(Model.Rejectedleave);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <span class=""desc"">Rejected Requests</span>
            <div class=""icon"">
                <i class=""zmdi zmdi-block""></i>
            </div>
        </div>
    </div>
    <div class=""col-md-6 col-lg-3"">
        <div class=""statistic__item"">
            <h2 class=""number"">");
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                          Write(Model.TotalLeave);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
            <span class=""desc"">Total Request</span>
            <div class=""icon"">
                <i class=""zmdi zmdi-account-o""></i>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""au-card recent-report"">
            <div class=""au-card-inner"">
                <h3 class=""title-2"">recent reports For Leave Requests</h3>
                <div id=""piechart""> </div>
");
            WriteLiteral("            </div>\n        </div>\n    </div>\n    \n</div>\n");
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
#line 65 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                              Write(Model.approveleave);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n                [\'Rejected Leave\', ");
#nullable restore
#line 66 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
                              Write(Model.Rejectedleave);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n                [\'Pending  Leave\',");
#nullable restore
#line 67 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\HomePageHOD.cshtml"
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
